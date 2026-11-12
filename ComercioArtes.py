import sys
import pyodbc

# Configuración de la conexión a SQL Server
SERVER = '.'
DATABASE = 'ComercioArtesDB'
USE_WINDOWS_AUTH = True

if USE_WINDOWS_AUTH:
    CONNECTION_STRING = (
        f"DRIVER={{ODBC Driver 17 for SQL Server}};"
        f"SERVER={SERVER};"
        f"DATABASE={DATABASE};"
        f"Trusted_Connection=yes;"
    )
else:
    USER = 'tu_usuario'
    PASSWORD = 'tu_contraseña'
    CONNECTION_STRING = (
        f"DRIVER={{ODBC Driver 17 for SQL Server}};"
        f"SERVER={SERVER};"
        f"DATABASE={DATABASE};"
        f"UID={USER};"
        f"PWD={PASSWORD};"
    )

def limpiar_consola():
    """Limpia la pantalla de la consola según el sistema operativo."""
    import os
    os.system('cls' if os.name == 'nt' else 'clear')

def obtener_conexion():
    """Establece y retorna la conexión a la base de datos."""
    try:
        conexion = pyodbc.connect(CONNECTION_STRING)
        return conexion
    except Exception as e:
        print(f"[ERROR CRÍTICO] No se pudo conectar a la Base de Datos: {e}")
        sys.exit(1)

def mostrar_usuarios(cursor):
    """Opción 1: Muestra los usuarios con su nombre y celular."""
    limpiar_consola()
    try:
        cursor.execute("""
            SELECT Nombre, Apellido, Telefono 
            FROM Usuarios
        """)
        usuarios = cursor.fetchall()

        print("=" * 75)
        print("                     LISTADO DE USUARIOS REGISTRADOS")
        print("=" * 75)
        print(f" {'Nombre y Apellido':<35} | {'Celular / Teléfono':<25}")
        print("-" * 75)
        
        if usuarios:
            for user in usuarios:
                nombre = f"{user[0]} {user[1]}" if user[0] and user[1] else "N/A"
                celular = str(user[2]) if user[2] else "Sin registrar"
                
                nombre = (nombre[:32] + '..') if len(nombre) > 34 else nombre
                
                print(f" {nombre:<35} | {celular:<25}")
        else:
            print(" No hay usuarios registrados.")
            
        print("=" * 75)
    except Exception as ex:
        print(f"[ERROR] Al consultar usuarios: {ex}")
    
    input("\nPresione ENTER para regresar al menú...")

def mostrar_reporte(cursor):
    """Opción 2: Muestra el reporte general del sistema (Dashboard)."""
    try:
        # 1. Obtener métricas generales
        cursor.execute("""
            SELECT 
                (SELECT COUNT(*) FROM Usuarios WHERE RolID = 2) AS TotalArtistas,
                (SELECT COUNT(*) FROM ObrasArte WHERE Activo = 1) AS TotalObras,
                (SELECT COUNT(*) FROM ObrasArte WHERE Activo = 1 AND Estado NOT IN ('Vendida', 'Agotado', 'Vendido')) AS Disponibles,
                (SELECT COUNT(*) FROM ObrasArte WHERE Activo = 1 AND Estado IN ('Vendida', 'Agotado', 'Vendido')) AS Vendidas,
                (SELECT ISNULL(SUM(Total), 0) FROM Pedidos) AS IngresosTotales
        """)
        row_metricas = cursor.fetchone()
        total_artistas = row_metricas[0] if row_metricas else 0
        total_obras = row_metricas[1] if row_metricas else 0
        disponibles = row_metricas[2] if row_metricas else 0
        vendidas = row_metricas[3] if row_metricas else 0
        ingresos = row_metricas[4] if row_metricas else 0.0

        # 2. Obtener listado de obras del catálogo
        cursor.execute("""
            SELECT o.ObraID, o.Titulo, ISNULL(u.Nombre + ' ' + u.Apellido, 'Sin Asignar') AS Artista, 
                   o.Tecnica, o.Precio, o.Estado
            FROM ObrasArte o
            LEFT JOIN Artistas a ON o.ArtistaID = a.ArtistaID
            LEFT JOIN Usuarios u ON a.ArtistaID = u.UsuarioID
            WHERE o.Activo = 1
        """)
        obras = cursor.fetchall()

        # 3. Obtener transacciones / pedidos recientes
        cursor.execute("""
            SELECT TOP 5 p.PedidoID, p.FechaPedido, 
                   ISNULL(u.Nombre + ' ' + u.Apellido, 'Cliente General') AS Comprador, p.Total
            FROM Pedidos p
            LEFT JOIN Compradores c ON p.CompradorID = c.CompradorID
            LEFT JOIN Usuarios u ON c.CompradorID = u.UsuarioID OR p.CompradorID = u.UsuarioID
            ORDER BY p.FechaPedido DESC
        """)
        pedidos = cursor.fetchall()

        # --- DISEÑO DEL REPORTE EN CONSOLA ---
        limpiar_consola()
        print("=" * 78)
        print("                 COMERCIO ARTES - REPORTE GENERAL DEL SISTEMA")
        print("=" * 78)
        print(" Fecha de emisión: En vivo desde la Base de Datos SQL Server")
        print("-" * 78)

        # Sección de Métricas
        print("\n [ RESUMEN GENERAL ]")
        print(f"  • Artistas Registrados : {total_artistas}")
        print(f"  • Obras en Catálogo    : {total_obras}")
        print(f"  • Obras Disponibles    : {disponibles}")
        print(f"  • Obras Vendidas       : {vendidas}")
        print(f"  • Ingresos Totales     : ${ingresos:,.2f}")
        print("-" * 78)

        # Sección de Catálogo de Obras
        print("\n [ CATÁLOGO DE OBRAS ]")
        print(f" {'ID':<4} | {'Título':<22} | {'Artista':<18} | {'Técnica':<12} | {'Precio':<9} | {'Estado':<10}")
        print("-" * 85)
        for obra in obras:
            obra_id, titulo, artista, tecnica, precio, estado = obra
            titulo = (titulo[:19] + '..') if len(str(titulo)) > 21 else str(titulo)
            artista = (artista[:15] + '..') if len(str(artista)) > 17 else str(artista)
            print(f" {obra_id:<4} | {titulo:<22} | {artista:<18} | {tecnica:<12} | ${precio:<8,.2f} | {estado:<10}")
        print("-" * 78)

        # Sección de Transacciones Recientes
        print("\n [ ÚLTIMAS TRANSACCIONES / FACTURAS ]")
        print(f" {'ID':<4} | {'Fecha':<18} | {'Comprador':<30} | {'Monto Total':<10}")
        print("-" * 78)
        if pedidos:
            for pedido in pedidos:
                ped_id, fecha, comprador, total = pedido
                fecha_str = fecha.strftime('%d/%m/%Y %H:%M') if fecha else "N/A"
                comprador = (comprador[:27] + '..') if len(str(comprador)) > 29 else str(comprador)
                print(f" {ped_id:<4} | {fecha_str:<18} | {comprador:<30} | ${total:<9,.2f}")
        else:
            print(" No se encontraron transacciones registradas.")
        print("=" * 78)

    except Exception as ex:
        print(f"[ERROR] Al generar el reporte: {ex}")
    
    input("\nPresione ENTER para regresar al menú...")

def menu_principal():
    """Bucle principal que gestiona el menú interactivo."""
    conexion = obtener_conexion()
    cursor = conexion.cursor()

    try:
        while True:
            limpiar_consola()
            print("=" * 55)
            print("         COMERCIO ARTES - MENÚ INTERACTIVO DE CONSOLA")
            print("=" * 55)
            print(" [1] Ver Usuarios (Nombre y Celular)")
            print(" [2] Ver Reporte General del Sistema (Dashboard)")
            print(" [3] Salir")
            print("=" * 55)
            
            opcion = input(" Seleccione una opción (1-3): ").strip()

            if opcion == '1':
                mostrar_usuarios(cursor)
            elif opcion == '2':
                mostrar_reporte(cursor)
            elif opcion == '3':
                limpiar_consola()
                print("\n ¡Gracias por utilizar Comercio Artes! Saliendo del sistema...\n")
                sys.exit(0)  # Cierra la consola inmediatamente
            else:
                input("\n[!] Opción inválida. Presione ENTER para intentar de nuevo...")
    finally:
        cursor.close()
        conexion.close()

if __name__ == "__main__":
    menu_principal()