# AppGestion

## Descripción

AppGestion es una aplicación WinForms desarrollada en VB.NET para la gestión administrativa y económica de una comisión fallera.

La aplicación permite gestionar:

- Censo de falleros.
- Datos personales y familiares.
- Cuotas y remesas bancarias.
- Historial de altas y bajas.
- Recompensas.
- Informes e impresos.
- Gestión económica del ejercicio.

La versión inicial almacenada en este repositorio es la **v3.0.0.4**.

---

# Entorno de desarrollo

- Visual Studio 2019
- .NET Framework 4.7.2
- MySQL
- Aiven Cloud
- Microsoft ReportViewer (RDLC)

---

# Configuración de la conexión a base de datos

Por motivos de seguridad las credenciales reales de Aiven NO se almacenan en este repositorio.

El archivo:

App.config

está excluido mediante .gitignore y no se sube a GitHub.

La aplicación utiliza la cadena de conexión real almacenada localmente en dicho archivo.

---

# IMPORTANTE \- DataSets y diseñador de Visual Studio

Durante la preparación del repositorio para GitHub se eliminaron las credenciales reales de los archivos:

My Project\\Settings.settings

My Project\\Settings.Designer.vb

Las cadenas reales fueron sustituidas por:

CAMBIAR\_POR\_CADENA\_REAL

para evitar que GitHub detectara y bloqueara credenciales de Aiven.

---

# Si es necesario modificar DataSets

Si en el futuro es necesario:

- Añadir DataTables.
- Crear nuevos TableAdapter.
- Modificar consultas.
- Regenerar DataSets.
- Utilizar asistentes de Visual Studio relacionados con bases de datos.

es posible que Visual Studio necesite una cadena de conexión válida en:

My Project\\Settings.settings

En ese caso:

1. Restaurar temporalmente la cadena de conexión real de Aiven.
2. Realizar las modificaciones necesarias en los DataSets.
3. Verificar que la aplicación funciona correctamente.
4. Sustituir nuevamente la cadena por:

CAMBIAR\_POR\_CADENA\_REAL

1. Comprobar que se regenera correctamente:

My Project\\Settings.Designer.vb

1. Antes de hacer commit verificar que NO aparecen referencias a:

aivencloud

avnadmin

AVNS\_

mediante búsquedas globales.

1. Realizar commit y push a GitHub.

---

# Certificado SSL

La conexión a MySQL/Aiven utiliza un certificado local.

Verificar que existe el archivo:

C:\\Datos\\MySQL\_Local\\ca.pem

si se restaura una cadena de conexión real para tareas de diseño.

---

# GitHub

Repositorio principal:

[https://github.com/Joseangelml360/AppGestion](https://github.com/Joseangelml360/AppGestion)

Rama principal:

main

---

# Historial

## v3.0.0.4

- Primera versión almacenada en GitHub.
- Repositorio recreado desde cero.
- Eliminadas credenciales reales de Aiven.
- Configuración preparada para trabajo seguro con GitHub.

# Recuperación de la cadena de conexión para diseño de DataSets

## Situación actual

Por motivos de seguridad, las credenciales reales de Aiven NO se almacenan en GitHub.

Los archivos:

My Project\\Settings.settings

My Project\\Settings.Designer.vb

contienen valores ficticios:

CAMBIAR\_POR\_CADENA\_REAL

Esto permite subir el proyecto a GitHub sin que GitHub Push Protection bloquee los commits.

---

## Cuándo será necesario restaurar temporalmente la conexión

Solo cuando se utilicen herramientas de diseño de Visual Studio relacionadas con bases de datos:

- Añadir DataTables.
- Crear TableAdapter.
- Modificar consultas de DataSets.
- Regenerar DataSets (.xsd).
- Utilizar asistentes de conexión a datos.

Para la ejecución normal de AppGestion NO es necesario modificar estos archivos.

La aplicación utiliza la cadena de conexión real almacenada localmente en:

App.config

---

## Cómo recuperar la cadena de conexión real

### Opción 1 (recomendada)

Abrir:

App.config

y localizar:

<connectionStrings>La cadena utilizada por la aplicación se encuentra en este apartado.

---

### Opción 2

Abrir MySQL Workbench:

MySQL Workbench

→ MySQL Connections

→ Edit Connection

y consultar:

- Hostname
- Port
- Username

La contraseña puede no mostrarse porque se almacena de forma segura.

---

## Procedimiento para modificar DataSets

1. Copiar temporalmente la cadena real en:

My Project\\Settings.settings

1. Guardar el archivo.
2. Verificar que Visual Studio regenera:

My Project\\Settings.Designer.vb

1. Realizar las modificaciones necesarias en los DataSets.
2. Comprobar que todo funciona correctamente.
3. Antes de hacer commit:
    - Sustituir nuevamente la cadena real por:

CAMBIAR\_POR\_CADENA\_REAL

1. Verificar que NO aparecen referencias a:

aivencloud

avnadmin

AVNS\_

mediante:

findstr /s /i "aivencloud" \*.vb \*.settings

findstr /s /i "avnadmin" \*.vb \*.settings

findstr /s /i "AVNS\_" \*.vb \*.settings

1. Realizar commit y push a GitHub.

---

## Nota importante

Si GitHub bloquea un push indicando:

Aiven Service Password

revisar siempre:

My Project\\Settings.settings

My Project\\Settings.Designer.vb

antes de revisar App.config.

Durante la primera subida del proyecto a GitHub, el origen del bloqueo se encontraba en estos archivos y no en App.config.



