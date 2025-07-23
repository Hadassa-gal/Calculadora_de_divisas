

# C#

# 🔑Introducción

Este Skill está orientado en la creación de diversos tipos de aplicaciones seguras y sólidas de escritorio, web y móviles, mediante la utilización del lenguaje de programación C#, para que se ejecutan en una plataforma de código abierto (.NET).

# 🔑Objetivos

🔓Construir proyectos de consola en C#, mediante la práctica, con el fin de adquirir los fundamentos del lenguaje de programación y  comenzar a utilizar el Framework .NET Core

🔓Aprender los diferentes conceptos del framework (.NET Core), que es una versión modular y ligera de (.NET Framework) a través de la implementación de distintos ejercicios.

🔓Construir programas usando los conceptos de la programación orientada a objetos y su implementación en C#.

# Modulo 1 Fundamentos C# y .Net

**Descripción del módulo**

Este módulo tiene como propósito introducir a los estudiantes en el ecosistema de desarrollo de aplicaciones con **C# y .NET**, haciendo énfasis en su arquitectura, ventajas, entornos compatibles y configuración inicial. A través de sesiones prácticas y explicativas, se orienta al estudiante en el conocimiento de las bases del lenguaje, el entorno de ejecución multiplataforma .NET Core/8, así como la instalación y validación del SDK en diferentes sistemas operativos. Al finalizar el módulo, el estudiante será capaz de crear, abrir y explorar la estructura básica de un proyecto en C#.

### Objetivos del módulo:

- Comprender los fundamentos del lenguaje C# y su enfoque orientado a objetos y componentes.
- Conocer la arquitectura y filosofía de desarrollo de .NET Core como plataforma moderna, modular y multiplataforma.
- Identificar los lenguajes compatibles y las ventajas/desventajas del ecosistema .NET.
- Instalar y validar correctamente el SDK de .NET en sistemas Windows y Linux.
- Crear, abrir y comprender la estructura de un proyecto de consola en C# utilizando la CLI de .NET.

### Resultados esperados:

Al finalizar este módulo, los estudiantes serán capaces de:

✅ Comprender qué es C# y cómo se inserta en el entorno .NET.

✅ Diferenciar entre .NET Framework y .NET Core.

✅ Explicar las ventajas y limitaciones de usar .NET Core en proyectos reales.

✅ Instalar y validar correctamente el SDK y el runtime de .NET en distintos sistemas operativos.

✅ Crear aplicaciones de consola en C# utilizando la línea de comandos.

✅ Identificar la estructura interna de un proyecto .NET básico (archivos y carpetas clave).

✅ Utilizar Visual Studio Code como entorno de desarrollo para trabajar con proyectos en C#.

## Sesión 1: Introducción a .Net

**Descripción de la sesión:** Esta sesión busca familiarizar al estudiante con el entorno de desarrollo de .NET en sistemas Linux, presentando la versión actual instalada del SDK y los runtimes disponibles, así como los pasos básicos para validar una instalación exitosa.

------

**Tema general:** Verificación del entorno de desarrollo .NET en Linux (Ubuntu).

**Objetivo de la sesión:**
 Introducir al estudiante en el ecosistema de .NET sobre una distribución Linux, revisando la versión instalada del SDK, runtimes disponibles y entorno del sistema operativo, como paso previo al desarrollo de aplicaciones con .NET 8.

**Resultados esperados. Después de la sesión, el estudiante aprenderá:**

- Verificar la instalación de .NET en un sistema Linux.
- Comprender la información que entrega el comando `dotnet --info`.
- Identificar la versión del SDK y del runtime instalados.
- Validar compatibilidad del entorno con desarrollo en ASP.NET Core.
- Conocer rutas de instalación y variables relevantes para el entorno .NET.

**Tiempo práctico estimado:** 30 minutos

### 1.1. Conociendo Lenguaje C#

C# es un lenguaje de programación orientado a componentes, orientado a objetos. C# proporciona construcciones de lenguaje para admitir directamente estos conceptos, por lo que se trata de un lenguaje natural en el que crear y usar componentes de software. Desde su origen, C# ha agregado características para admitir nuevas cargas de trabajo y prácticas de diseño de software emergentes. En el fondo, C# es un lenguaje orientado a objetos. Defina los tipos y su comportamiento. 

Recurso oficial : https://learn.microsoft.com/es-es/dotnet/csharp/tour-of-csharp/

### 1.2. Arquitectura .NET Core

.NET Core es un marco de trabajo (framework) de código abierto y multiplataforma desarrollado por Microsoft. Proporciona una plataforma para construir aplicaciones modernas, incluyendo aplicaciones web, servicios web, aplicaciones de consola y más. .NET Core es una versión modular y ligera de .NET Framework, diseñada para ser más rápida y eficiente, y es compatible con Windows, macOS y Linux. Una de las características clave de .NET Core es su capacidad para crear aplicaciones que se ejecutan en múltiples sistemas operativos. Esto significa que puede desarrollar una aplicación en .NET Core y ejecutarla en diferentes plataformas sin necesidad de cambios significativos en el código fuente. Además, .NET Core ofrece una mayor flexibilidad en cuanto a la elección del entorno de desarrollo, ya que se puede utilizar con herramientas como Visual Studio, Visual Studio Code o la línea de comandos. Otra ventaja de .NET Core es su rendimiento mejorado y su menor consumo de recursos. Está diseñado para ser más rápido y escalable que su predecesor, lo que lo hace adecuado para aplicaciones de alto rendimiento y escala. Además, .NET Core se integra con tecnologías modernas como Docker y la computación en la nube, lo que facilita la implementación y el despliegue de aplicaciones en entornos distribuidos. En resumen, .NET Core es un marco de trabajo de desarrollo de software multiplataforma y de alto rendimiento, que permite la creación de aplicaciones modernas y escalables para diferentes sistemas operativos.

### 1.3. Lenguajes soportados por .Net Core

.NET Core admite varios lenguajes de programación, aunque algunos de ellos pueden tener un nivel de soporte y compatibilidad diferente. Los lenguajes principales que se pueden utilizar con .NET Core son:

- C#: Es el lenguaje principal utilizado en el ecosistema de .NET Core. Es un lenguaje de programación multiparadigma y orientado a objetos que se utiliza ampliamente para desarrollar aplicaciones en .NET.
- F#: Es un lenguaje funcional que se ejecuta en la plataforma .NET. F# es compatible con .NET Core y ofrece ventajas en el desarrollo de aplicaciones funcionales y científicas.
- Visual Basic ([VB.NET](http://vb.net/)): Aunque no es tan utilizado como C#, Visual Basic es un lenguaje compatible con .NET Core. Es un lenguaje orientado a objetos y de propósito general.

Además de estos lenguajes principales, .NET Core también admite otros lenguajes, aunque con un nivel de soporte y compatibilidad variado. Algunos ejemplos incluyen:

- **C++/CLI**: Permite utilizar el lenguaje C++ en combinación con .NET Core.
- **IronPython**: Implementación de Python que se ejecuta en la plataforma .NET.
- **IronRuby:** Implementación de Ruby que se ejecuta en la plataforma .NET.
- **TypeScript**: Aunque TypeScript es un lenguaje de programación desarrollado por Microsoft, no se ejecuta directamente en .NET Core. Sin embargo, se puede integrar fácilmente en proyectos de .NET Core para desarrollar aplicaciones web utilizando Angular u otras bibliotecas de C#Script.

Es importante tener en cuenta que el nivel de soporte y compatibilidad puede variar entre los diferentes lenguajes en función de las herramientas y bibliotecas disponibles. C# es el lenguaje más ampliamente utilizado y mejor soportado en el ecosistema de .NET Core.

### 1.4. Ventajas y Desventajas de .NET Core

#### 1.4.1. Ventajas de utilizar .NET Core

- **Multiplataforma**: .NET Core es compatible con Windows, macOS y Linux. Esto permite desarrollar aplicaciones que se ejecutan en diferentes sistemas operativos sin necesidad de realizar cambios significativos en el código fuente.
- **Rendimiento y escalabilidad**: .NET Core ha sido diseñado para ofrecer un rendimiento mejorado y un menor consumo de recursos en comparación con versiones anteriores de .NET Framework. Esto lo hace adecuado para aplicaciones de alto rendimiento y escala.
- **Modularidad**: .NET Core adopta un enfoque modular, lo que significa que solo se incluyen los componentes necesarios para una aplicación específica. Esto resulta en aplicaciones más ligeras y eficientes, y facilita la administración de dependencias.
- **Open source**: .NET Core es un proyecto de código abierto, lo que significa que su desarrollo es transparente y existe una comunidad activa que contribuye al proyecto. Esto permite una mayor transparencia, participación y mejora continua.
- **Integración con tecnologías modernas**: .NET Core se integra bien con tecnologías modernas como Docker, Kubernetes y la computación en la nube. Esto facilita la implementación y el despliegue de aplicaciones en entornos distribuidos.

#### 1.4.2. Desventajas de utilizar .NET Core

- **Menor compatibilidad con algunas bibliotecas y herramientas**: Debido a que .NET Core es una versión más reciente y modular de .NET, puede haber algunas bibliotecas y herramientas que no son completamente compatibles con él. Esto puede requerir adaptaciones o buscar alternativas.
- **Curva de aprendizaje**: Si estás familiarizado con versiones anteriores de .NET Framework, puede requerir un tiempo de aprendizaje adicional para adaptarse a los cambios y características de .NET Core.
- **Ecosistema menos maduro**: Aunque .NET Core ha ganado popularidad y ha crecido su ecosistema, aún puede haber una menor disponibilidad de ciertas bibliotecas o herramientas en comparación con .NET Framework. Sin embargo, este problema se ha ido mitigando con el tiempo y muchas bibliotecas populares ahora tienen soporte para .NET Core.
- **Menor soporte para algunas características específicas de Windows**: Aunque .NET Core es multiplataforma, algunas características específicas de Windows pueden tener un soporte limitado o requerir un enfoque diferente en comparación con .NET Framework.

### 1.5. Configuración del entorno de desarrollo

Para desarrollar en .NET Core, necesitarás cumplir con los siguientes requisitos:

- Sistema operativo compatible: .NET Core es compatible con Windows, macOS y Linux. Asegúrate de tener un sistema operativo compatible instalado en tu máquina.
- SDK de .NET Core: Debes descargar e instalar el SDK (Software Development Kit) de .NET Core correspondiente a tu sistema operativo desde el sitio web oficial de .NET Core. El SDK incluye las herramientas necesarias para desarrollar aplicaciones con .NET Core.
- Entorno de desarrollo integrado (IDE): Aunque no es estrictamente necesario, se recomienda utilizar un IDE para facilitar el desarrollo en .NET Core. Microsoft Visual Studio es el IDE principal para .NET Core y ofrece características avanzadas para la programación en C# y otros lenguajes de .NET. También puedes utilizar Visual Studio Code, un editor de código ligero y altamente personalizable, que también es compatible con .NET Core.
- Conocimientos de programación: Para desarrollar en .NET Core, es necesario tener conocimientos de programación en C# u otros lenguajes compatibles con .NET Core, como F# o Visual Basic. Familiarizarte con los conceptos de programación orientada a objetos y los principios básicos de .NET Framework también es útil.
- Control de versiones: Es recomendable utilizar un sistema de control de versiones, como Git, para mantener un registro de los cambios realizados en tu proyecto y facilitar la colaboración con otros desarrolladores. Estos son los requisitos básicos para comenzar a desarrollar en .NET Core. A medida que te familiarices con el entorno y el desarrollo en .NET Core, también podrías necesitar aprender sobre las bibliotecas y frameworks adicionales que se utilizan comúnmente en el desarrollo de aplicaciones, como [ASP.NET](http://asp.net/) Core para el desarrollo web o Entity Framework Core para el acceso a bases de datos.

#### 1.5.1. Instalación Windows

1. Ingrese a la Url oficial  https://dotnet.microsoft.com/en-us/download y descargue larsión LTS 8.0

   ![](https://i.ibb.co/sJgRK7yr/image.png)

2. En la ventana de descarga seleccione la carpeta de descarga y haga clic en guardar

   <img src="https://i.ibb.co/9mFK193v/image.png" style="zoom:67%;" />

3. Hacer  doble clic sobre el instalador y siga los pasos del asistente

   ![](https://i.ibb.co/GQ3FdQd8/net-Install.png)

4. Abra la terminal del sistema operativo windows (cmd o powershell)

5. Ingrese el comando **dotnet --info** A continuación se observa el resultado de la ejecucion donde se valida la instalacion del SDK y las herramientas necesarias para la creación de proyecto usando c#.

   ```less
   PS C:\Users\developer> dotnet --info
   SDK DE .NET:
    Version:           8.0.405
    Commit:            fb1830d421
    Workload version:  8.0.400-manifests.87fdb0b5
    MSBuild version:   17.11.9+a69bbaaf5
   
   Entorno de tiempo de ejecución:
    OS Name:     Windows
    OS Version:  10.0.26100
    OS Platform: Windows
    RID:         win-x64
    Base Path:   C:\Program Files\dotnet\sdk\8.0.405\
   
   Cargas de trabajo de .NET instaladas:
   Configurado para usar loose manifests al instalar nuevos manifiestos.
   No hay cargas de trabajo instaladas para mostrar.
   
   Host:
     Version:      8.0.12
     Architecture: x64
     Commit:       89ef51c5d8
   
   .NET SDKs installed:
     8.0.403 [C:\Program Files\dotnet\sdk]
     8.0.405 [C:\Program Files\dotnet\sdk]
   
   .NET runtimes installed:
     Microsoft.AspNetCore.App 8.0.10 [C:\Program Files\dotnet\shared\Microsoft.AspNetCore.App]
     Microsoft.AspNetCore.App 8.0.12 [C:\Program Files\dotnet\shared\Microsoft.AspNetCore.App]
     Microsoft.NETCore.App 6.0.16 [C:\Program Files\dotnet\shared\Microsoft.NETCore.App]
     Microsoft.NETCore.App 8.0.10 [C:\Program Files\dotnet\shared\Microsoft.NETCore.App]
     Microsoft.NETCore.App 8.0.12 [C:\Program Files\dotnet\shared\Microsoft.NETCore.App]
     Microsoft.WindowsDesktop.App 8.0.10 [C:\Program Files\dotnet\shared\Microsoft.WindowsDesktop.App]
     Microsoft.WindowsDesktop.App 8.0.12 [C:\Program Files\dotnet\shared\Microsoft.WindowsDesktop.App]
   
   Other architectures found:
     x86   [C:\Program Files (x86)\dotnet]
       registered at [HKLM\SOFTWARE\dotnet\Setup\InstalledVersions\x86\InstallLocation]
   
   Environment variables:
     Not set
   
   global.json file:
     Not found
   
   Learn more:
     https://aka.ms/dotnet/info
   
   Download .NET:
     https://aka.ms/dotnet/download
   ```

   ​	

#### 1.5.2. Instalación Linux

1. Abrir la terminal de linux Ctrl+Alt+T

2. Ingresar el comando **sudo apt remove 'dotnet*'** para eliminar los paquetes de net core que se encuentren instalados. 

   ```less
   jjpardo@johlver-virtual-machine:~$ sudo apt remove 'dotnet*'
   [sudo] password for jjpardo: 
   Reading package lists... Done
   Building dependency tree... Done
   Reading state information... Done
   Note, selecting 'dotnet-runtime-dbg-8.0' for glob 'dotnet*'
   Note, selecting 'dotnet-sdk-8.0-source-built-artifacts' for glob 'dotnet*'
   Note, selecting 'dotnet-hostfxr-3.1' for glob 'dotnet*'
   Note, selecting 'dotnet-hostfxr-6.0' for glob 'dotnet*'
   Note, selecting 'dotnet-hostfxr-7.0' for glob 'dotnet*'
   Note, selecting 'dotnet-hostfxr-8.0' for glob 'dotnet*'
   Note, selecting 'dotnet-hostfxr-9.0' for glob 'dotnet*'
   Note, selecting 'dotnet-sdk-3.1' for glob 'dotnet*'
   Note, selecting 'dotnet-sdk-6.0' for glob 'dotnet*'
   Note, selecting 'dotnet-sdk-7.0' for glob 'dotnet*'
   Note, selecting 'dotnet-sdk-8.0' for glob 'dotnet*'
   Note, selecting 'dotnet-sdk-9.0' for glob 'dotnet*'
   Note, selecting 'dotnet-targeting-pack-3.1' for glob 'dotnet*'
   Note, selecting 'dotnet6' for glob 'dotnet*'
   Note, selecting 'dotnet7' for glob 'dotnet*'
   Note, selecting 'dotnet8' for glob 'dotnet*'
   Note, selecting 'dotnet-targeting-pack-6.0' for glob 'dotnet*'
   Note, selecting 'dotnet-targeting-pack-7.0' for glob 'dotnet*'
   Note, selecting 'dotnet-targeting-pack-8.0' for glob 'dotnet*'
   Note, selecting 'dotnet-targeting-pack-9.0' for glob 'dotnet*'
   Note, selecting 'dotnet-nightly' for glob 'dotnet*'
   Note, selecting 'dotnet-sdk-dbg-8.0' for glob 'dotnet*'
   Note, selecting 'dotnet-templates-6.0' for glob 'dotnet*'
   Note, selecting 'dotnet-templates-7.0' for glob 'dotnet*'
   Note, selecting 'dotnet-templates-8.0' for glob 'dotnet*'
   Note, selecting 'dotnet-host-7.0' for glob 'dotnet*'
   Note, selecting 'dotnet-host-8.0' for glob 'dotnet*'
   Note, selecting 'dotnet-host' for glob 'dotnet*'
   Note, selecting 'dotnet-runtime-deps-3.1' for glob 'dotnet*'
   Note, selecting 'dotnet-runtime-deps-6.0' for glob 'dotnet*'
   Note, selecting 'dotnet-runtime-deps-7.0' for glob 'dotnet*'
   Note, selecting 'dotnet-runtime-deps-8.0' for glob 'dotnet*'
   Note, selecting 'dotnet-runtime-deps-9.0' for glob 'dotnet*'
   Note, selecting 'dotnet' for glob 'dotnet*'
   Note, selecting 'dotnet-sdk-6.0-source-built-artifacts' for glob 'dotnet*'
   Note, selecting 'dotnet-apphost-pack-3.1' for glob 'dotnet*'
   Note, selecting 'dotnet-apphost-pack-6.0' for glob 'dotnet*'
   Note, selecting 'dotnet-apphost-pack-7.0' for glob 'dotnet*'
   Note, selecting 'dotnet-apphost-pack-8.0' for glob 'dotnet*'
   Note, selecting 'dotnet-apphost-pack-9.0' for glob 'dotnet*'
   Note, selecting 'dotnet-sdk-7.0-source-built-artifacts' for glob 'dotnet*'
   Note, selecting 'dotnet-runtime-3.1' for glob 'dotnet*'
   Note, selecting 'dotnet-runtime-6.0' for glob 'dotnet*'
   Note, selecting 'dotnet-runtime-7.0' for glob 'dotnet*'
   Note, selecting 'dotnet-runtime-8.0' for glob 'dotnet*'
   Note, selecting 'dotnet-runtime-9.0' for glob 'dotnet*'
   Package 'dotnet' is not installed, so not removed
   Package 'dotnet-nightly' is not installed, so not removed
   Package 'dotnet-targeting-pack-3.1' is not installed, so not removed
   Package 'dotnet-apphost-pack-6.0' is not installed, so not removed
   Package 'dotnet-host-8.0' is not installed, so not removed
   Package 'dotnet-hostfxr-6.0' is not installed, so not removed
   Package 'dotnet-runtime-6.0' is not installed, so not removed
   Package 'dotnet-sdk-6.0-source-built-artifacts' is not installed, so not removed
   Package 'dotnet-sdk-8.0-source-built-artifacts' is not installed, so not removed
   Package 'dotnet-targeting-pack-6.0' is not installed, so not removed
   Package 'dotnet-templates-6.0' is not installed, so not removed
   Package 'dotnet-templates-8.0' is not installed, so not removed
   Package 'dotnet6' is not installed, so not removed
   Package 'dotnet8' is not installed, so not removed
   Package 'dotnet-apphost-pack-7.0' is not installed, so not removed
   Package 'dotnet-host-7.0' is not installed, so not removed
   Package 'dotnet-hostfxr-7.0' is not installed, so not removed
   Package 'dotnet-runtime-7.0' is not installed, so not removed
   Package 'dotnet-runtime-dbg-8.0' is not installed, so not removed
   Package 'dotnet-sdk-7.0-source-built-artifacts' is not installed, so not removed
   Package 'dotnet-sdk-dbg-8.0' is not installed, so not removed
   Package 'dotnet-targeting-pack-7.0' is not installed, so not removed
   Package 'dotnet-templates-7.0' is not installed, so not removed
   Package 'dotnet7' is not installed, so not removed
   Package 'dotnet-runtime-deps-3.1' is not installed, so not removed
   Package 'dotnet-hostfxr-3.1' is not installed, so not removed
   Package 'dotnet-apphost-pack-3.1' is not installed, so not removed
   Package 'dotnet-runtime-3.1' is not installed, so not removed
   Package 'dotnet-sdk-3.1' is not installed, so not removed
   Package 'dotnet-sdk-7.0' is not installed, so not removed
   Package 'dotnet-runtime-deps-7.0' is not installed, so not removed
   Package 'dotnet-runtime-deps-6.0' is not installed, so not removed
   Package 'dotnet-sdk-6.0' is not installed, so not removed
   Package 'dotnet-apphost-pack-9.0' is not installed, so not removed
   Package 'dotnet-hostfxr-9.0' is not installed, so not removed
   Package 'dotnet-runtime-9.0' is not installed, so not removed
   Package 'dotnet-runtime-deps-9.0' is not installed, so not removed
   Package 'dotnet-targeting-pack-9.0' is not installed, so not removed
   Package 'dotnet-sdk-9.0' is not installed, so not removed
   Package 'dotnet-runtime-deps-8.0' is not installed, so not removed
   The following packages were automatically installed and are no longer required:
     aspnetcore-targeting-pack-8.0 liblttng-ust-common1 liblttng-ust-ctl5
     liblttng-ust1 netstandard-targeting-pack-2.1
   Use 'sudo apt autoremove' to remove them.
   The following packages will be REMOVED:
     aspnetcore-runtime-8.0 dotnet-apphost-pack-8.0 dotnet-host
     dotnet-hostfxr-8.0 dotnet-runtime-8.0 dotnet-sdk-8.0
     dotnet-targeting-pack-8.0
   0 upgraded, 0 newly installed, 7 to remove and 121 not upgraded.
   After this operation, 542 MB disk space will be freed.
   Do you want to continue? [Y/n] Y
   (Reading database ... 279953 files and directories currently installed.)
   Removing dotnet-sdk-8.0 (8.0.404-1) ...
   Removing aspnetcore-runtime-8.0 (8.0.12-0ubuntu1~22.04.1) ...
   Removing dotnet-apphost-pack-8.0 (8.0.12-0ubuntu1~22.04.1) ...
   Removing dotnet-runtime-8.0 (8.0.12-0ubuntu1~22.04.1) ...
   Removing dotnet-hostfxr-8.0 (8.0.11-1) ...
   Removing dotnet-host (8.0.11-1) ...
   Removing dotnet-targeting-pack-8.0 (8.0.12-0ubuntu1~22.04.1) ...
   jjpardo@johlver-virtual-machine:~$ 
   
   ```

3.  Ingresar el comando **sudo apt remove 'aspnetcore*'** para remover paquetes y servicios runtime de aspnetcore.

   ```less
   jjpardo@johlver-virtual-machine:~$ sudo apt remove 'aspnetcore*'
   Reading package lists... Done
   Building dependency tree... Done
   Reading state information... Done
   Note, selecting 'aspnetcore-runtime-3.1' for glob 'aspnetcore*'
   Note, selecting 'aspnetcore-runtime-6.0' for glob 'aspnetcore*'
   Note, selecting 'aspnetcore-runtime-7.0' for glob 'aspnetcore*'
   Note, selecting 'aspnetcore-runtime-8.0' for glob 'aspnetcore*'
   Note, selecting 'aspnetcore-runtime-9.0' for glob 'aspnetcore*'
   Note, selecting 'aspnetcore-runtime-dbg-8.0' for glob 'aspnetcore*'
   Note, selecting 'aspnetcore-targeting-pack-3.1' for glob 'aspnetcore*'
   Note, selecting 'aspnetcore-targeting-pack-6.0' for glob 'aspnetcore*'
   Note, selecting 'aspnetcore-targeting-pack-7.0' for glob 'aspnetcore*'
   Note, selecting 'aspnetcore-targeting-pack-8.0' for glob 'aspnetcore*'
   Note, selecting 'aspnetcore-targeting-pack-9.0' for glob 'aspnetcore*'
   Package 'aspnetcore-targeting-pack-3.1' is not installed, so not removed
   Package 'aspnetcore-runtime-6.0' is not installed, so not removed
   Package 'aspnetcore-targeting-pack-6.0' is not installed, so not removed
   Package 'aspnetcore-runtime-7.0' is not installed, so not removed
   Package 'aspnetcore-runtime-dbg-8.0' is not installed, so not removed
   Package 'aspnetcore-targeting-pack-7.0' is not installed, so not removed
   Package 'aspnetcore-runtime-3.1' is not installed, so not removed
   Package 'aspnetcore-runtime-9.0' is not installed, so not removed
   Package 'aspnetcore-targeting-pack-9.0' is not installed, so not removed
   Package 'aspnetcore-runtime-8.0' is not installed, so not removed
   The following packages were automatically installed and are no longer required:
     liblttng-ust-common1 liblttng-ust-ctl5 liblttng-ust1
     netstandard-targeting-pack-2.1
   Use 'sudo apt autoremove' to remove them.
   The following packages will be REMOVED:
     aspnetcore-targeting-pack-8.0
   0 upgraded, 0 newly installed, 1 to remove and 120 not upgraded.
   After this operation, 15,6 MB disk space will be freed.
   Do you want to continue? [Y/n] Y
   (Reading database ... 274953 files and directories currently installed.)
   Removing aspnetcore-targeting-pack-8.0 (8.0.12-0ubuntu1~22.04.1) ...
   jjpardo@johlver-virtual-machine:~$ 
   ```

4. Ejecutar el comando **sudo rm /etc/apt/sources.list.d/microsoft-prod.list** para eliminar repositorios en caso de haber instalado otras versiones de Net Core.

5. Ejecutar el comando **sudo apt update** para realizar actualización de paquetes en linux.

#### 1.5.3. Instalación del SDK

El SDK de .NET permite desarrollar aplicaciones con .NET. Si instala el SDK de .NET, no necesita instalar el entorno de ejecución correspondiente. Para instalar el SDK de .NET, ejecute los comandos siguientes:

```less
sudo apt-get install -y dotnet-sdk-8.0
```

#### 1.5.4. Instalación de la instancia en tiempo de ejecución

El entorno de ejecución de ASP.NET Core le permite ejecutar aplicaciones creadas con .NET en las que no se ha proporcionado el entorno de ejecución. Los comandos siguientes instalan el entorno de ejecución de ASP.NET Core, el más compatible con .NET. En el terminal, ejecute los comandos siguientes:

```less
sudo apt-get install -y aspnetcore-runtime-8.0
```

#### 1.5.5. Validación de la Instalación dotnet

Para validar la instalación ejecute el comando **dotnet --info** debera tener el siguiente resultado:

```less
trainer@johlver-virtual-machine:~$ dotnet --info
.NET SDK:
 Version:           8.0.405
 Commit:            fb1830d421
 Workload version:  8.0.400-manifests.c7afa696
 MSBuild version:   17.11.9+a69bbaaf5

Runtime Environment:
 OS Name:     ubuntu
 OS Version:  22.04
 OS Platform: Linux
 RID:         linux-x64
 Base Path:   /usr/share/dotnet/sdk/8.0.405/

.NET workloads installed:
Configured to use loose manifests when installing new manifests.
There are no installed workloads to display.

Host:
  Version:      8.0.12
  Architecture: x64
  Commit:       89ef51c5d8

.NET SDKs installed:
  8.0.405 [/usr/share/dotnet/sdk]

.NET runtimes installed:
  Microsoft.AspNetCore.App 8.0.12 [/usr/share/dotnet/shared/Microsoft.AspNetCore.App]
  Microsoft.NETCore.App 8.0.12 [/usr/share/dotnet/shared/Microsoft.NETCore.App]

Other architectures found:
  None

Environment variables:
  Not set

global.json file:
  Not found

Learn more:
  https://aka.ms/dotnet/info

Download .NET:
  https://aka.ms/dotnet/download

```

## Sesión 2: Creación de proyectos en c#

**Descripción **

En esta sesión, los estudiantes aprenderán a crear proyectos de consola en el lenguaje de programación **C#**, utilizando la **interfaz de línea de comandos (CLI)** de .NET tanto en **Windows** como en **Linux**. El objetivo es familiarizarse con el proceso de inicialización, apertura y exploración de un proyecto básico en C#, sentando así las bases para proyectos más complejos en el futuro.

También explorarán la estructura interna generada por defecto en un proyecto de consola: carpetas como `bin/`, `obj/`, archivos esenciales como `Program.cs`, el archivo de configuración `.csproj`, y cómo abrir el proyecto desde **Visual Studio Code** para iniciar el desarrollo.

**Tema general** : Inicialización y configuración de proyectos de consola en C# usando la CLI de .NET

**Resultados esperados. Después de la sesión, el estudiante aprenderá:**

- Utilizar la CLI de .NET para crear una aplicación de consola.
- Navegar por la estructura del proyecto generado por defecto.
- Abrir y editar el proyecto con Visual Studio Code.
- Comprender el propósito de los archivos y carpetas que componen un proyecto básico en C#.

### 1.6. Creación de proyectos en C#

#### 1.6.1. Windows

1. Abrir la consola del sistema operativo (cmd) o PowerShell(Windows 11)

2. Cree una carpeta donde se guarden los proyectos.

   ![](https://i.ibb.co/RpRcvdz5/image.png)

3. Ejecute el comando **dotnet new console -n NombreProyecto**

   ```less
   PS E:\projectsNet> dotnet new console -n baseApp
   
   Esto es .NET 8.0.
   ---------------------
   Versión del SDK: 8.0.405
   
   Telemetría
   ---------
   Las herramientas de .NET recopilan datos de uso para ayudarnos a mejorar su experiencia. Microsoft los recopila y los comparte con la comunidad. Puede optar por no participar en la telemetría si establece la variable de entorno DOTNET_CLI_TELEMETRY_OPTOUT en "1" o "true" mediante su shell favorito.
   
   Lea más sobre la telemetría de las herramientas de la CLI de .NET: https://aka.ms/dotnet-cli-telemetry
   
   ----------------
   Instalar un certificado de desarrollo HTTPS de ASP.NET Core.
   Para confiar en el certificado, ejecute "dotnet dev-certs https --trust"
   Obtenga información sobre HTTPS: https://aka.ms/dotnet-https
   
   ----------------
   Escribir su primera aplicación: https://aka.ms/dotnet-hello-world
   Descubra las novedades: https://aka.ms/dotnet-whats-new
   Explore la documentación: https://aka.ms/dotnet-docs
   Notificar problemas y encontrar el código fuente en GitHub: https://github.com/dotnet/core
   Use "dotnet --help" para ver los comandos disponibles o visite: https://aka.ms/dotnet-cli
   --------------------------------------------------------------------------------------
   La plantilla "Aplicación de consola" se creó correctamente.
   
   Procesando acciones posteriores a la creación...
   Restaurando E:\projectsNet\baseApp\baseApp.csproj:
     Determinando los proyectos que se van a restaurar...
     Se ha restaurado E:\projectsNet\baseApp\baseApp.csproj (en 56 ms).
   Restauración realizada correctamente.
   ```

#### 1.6.2. Linux

   1. Abra la terminal de linux Ctrl+Alt+T

   2. Cree una nueva carpeta donde se guarden los proyectos

      <img src="https://i.ibb.co/dwCmLXYJ/image.png" style="zoom:67%;" />

   3. Ejecute el comando **dotnet new console -n NombreProyecto**

      ```less
      jjpardo@johlver-virtual-machine:~/projectsNet$ dotnet new console -n baseApp
      The template "Console App" was created successfully.
      
      Processing post-creation actions...
      Restoring /home/jjpardo/projectsNet/baseApp/baseApp.csproj:
        Determining projects to restore...
        Restored /home/jjpardo/projectsNet/baseApp/baseApp.csproj (in 107 ms).
      Restore succeeded.
      
      jjpardo@johlver-virtual-machine:~/projectsNet$ 
      ```

#### 1.6.3. Abriendo el proyecto (Windows y Linux)

1. Ingrese a la carpeta del proyecto creado y ejecute el comando **code .**

2. Abra el archivo program.cs

   Si se esta abriendo por primera vez un proyecto de net se solicitara instalar la extensión de soporte de .Net para visual Studio Code.

   ![](https://i.ibb.co/gbHKd116/image.png)

   ![](https://i.ibb.co/mF2DM75D/image.png)

3. A continuación se abre la siguiente estructura de proyecto.

   ![](https://i.ibb.co/1GnXRFcW/image.png)

   #### 📂 **bin/**

   Esta carpeta contiene los archivos compilados (ejecutables y bibliotecas). En .NET, cuando se compila un proyecto, los archivos generados se almacenan aquí en diferentes configuraciones:

   - **Debug**: Contiene los archivos compilados en modo depuración.
   - **Release**: Contiene los archivos optimizados para producción.

   #### 📂 **obj/**

   Esta carpeta almacena archivos temporales y metadatos generados por el compilador. Contiene:

   - Archivos intermedios antes de la compilación final.
   - Metadatos sobre la compilación del proyecto.

   #### 📄 **baseApp.csproj**

   Es el **archivo de configuración del proyecto**. Contiene información sobre:

   - El **SDK** de .NET que usa el proyecto.
   - Las **dependencias y paquetes NuGet**.
   - La **versión de C#** utilizada.
   - Configuraciones como el **tipo de salida** (ejecutable o biblioteca).

   #### 📄 **baseApp.sln**

   Es el **archivo de solución de Visual Studio**. Una solución puede contener múltiples proyectos relacionados. Se usa para administrar varios proyectos en un solo entorno de desarrollo.

   #### 📄 **Program.cs**

   Este es el **archivo principal del programa**. En una aplicación .NET moderna (como una aplicación de consola o una API en .NET Core), este archivo contiene el **punto de entrada** (`Main`).
   
   ```c#
   internal class Program
   {
       private static void Main(string[] args)
       {
           Console.WriteLine("Hello, World!");
       }
   }
   ```

# Modulo 2 Programación Básica C#

Este módulo introduce al estudiante en los conceptos fundamentales de la programación utilizando el lenguaje C#. A lo largo de sus sesiones, el estudiante aprenderá desde la declaración de variables, tipos de datos y operadores, hasta estructuras de control y uso de arreglos. Mediante teoría, ejemplos prácticos y ejercicios guiados, se busca construir una base sólida para el desarrollo de aplicaciones básicas en C#, estimulando el pensamiento lógico, analítico y estructurado.

#### **Objetivo general del módulo:**

Desarrollar en los estudiantes las habilidades necesarias para comprender y aplicar los principios básicos de programación estructurada utilizando el lenguaje C#. Esto incluye la manipulación de datos, el control del flujo de ejecución y el trabajo con estructuras de almacenamiento como arreglos, sentando así las bases para proyectos más complejos en etapas posteriores del aprendizaje.

#### **Resultados esperados del módulo:**

Al finalizar este módulo, el estudiante será capaz de:

✅ Declarar y utilizar variables, constantes y tipos de datos primitivos en C# correctamente.

✅ Aplicar operadores aritméticos, de asignación, comparación y lógicos en expresiones y condiciones.

✅ Comprender y utilizar correctamente conversiones de tipos (implícitas, explícitas, `Convert`, `Parse`, `TryParse`).

✅ Utilizar caracteres de escape, interpolación de cadenas y formatos numéricos para dar salida a datos de forma controlada.

✅ Implementar estructuras de control condicional (`if`, `switch`) y estructuras iterativas (`for`, `while`, `do-while`, `foreach`) para el control del flujo de ejecución.

✅ Diseñar programas que tomen decisiones y repitan instrucciones según condiciones dinámicas.

✅ Declarar, inicializar, recorrer y manipular arreglos unidimensionales en C# mediante estructuras de control y métodos de la clase `Array`.

## Sesión 1 Variables, palabras reservadas, entrada y salida de datos

**Descripción de la sesión:** Esta sesión introduce al estudiante a los fundamentos esenciales de la programación en C#, incluyendo variables, constantes, tipos de datos, conversiones y operadores. A través de teoría y ejemplos prácticos, se espera que el estudiante adquiera una comprensión sólida para desarrollar programas sencillos.

------

**Tema general:** Fundamentos de programación en C#.

**Objetivo de la sesión:**
 Familiarizar al estudiante con los elementos básicos del lenguaje C#, abordando la declaración de variables y constantes, tipos de datos y su conversión, así como el uso de operadores matemáticos y estructuras de entrada/salida en consola.

**Resultados esperados. Después de la sesión, el estudiante aprenderá:**

- Qué son las variables y constantes en C# y cómo declararlas.
- Tipos de datos primitivos (enteros, flotantes, literales) y cómo se almacenan.
- Realizar conversiones implícitas y explícitas entre tipos.
- Utilizar operadores aritméticos, de asignación y comparación.
- Imprimir y recibir datos desde la consola con `Console.WriteLine()` y `Console.ReadLine()`.
- Aplicar el uso de cadenas interpoladas y caracteres de escape.
- Reconocer palabras clave y su rol dentro del lenguaje.

**Tiempo práctico estimado:** 60 minutos

#### 2.1. Variables y constantes

##### 2.1.1. Variables

En programación, una variable es un espacio de memoria reservado para almacenar un valor específico. Las variables tienen un nombre único y pueden contener diferentes tipos de datos, como números, texto, booleanos, objetos, entre otros. Al utilizar variables, los programadores pueden almacenar y manipular datos de manera dinámica en un programa. Las variables permiten almacenar valores temporales o resultados intermedios de cálculos, y también facilitan la comunicación y transferencia de datos entre diferentes partes de un programa.

```c#
string name = string.Empty;
```

##### 2.1.2. Constantes

En C#, una constante es un valor inmutable que no puede cambiar una vez que se le ha asignado un valor inicial. Las constantes se declaran utilizando la palabra clave "const" y deben recibir un valor en el momento de la declaración.

```c#
const double PI = 3.14159;
```

#### 2.2. Tipos de Datos y Conversiones

##### 2.2.1. Tipos numéricos enteros

Los tipos numéricos integrales representan números enteros. Todos los tipos numéricos integrales son tipos de valor. También son tipos simples y se pueden inicializar con literales. Todos los tipos numéricos enteros admiten operadores aritméticos, lógicos bit a bit, de comparación y de igualdad.

| Palabra clave/tipo de C# | Intervalo                                                   | Tamaño                                | Tipo de .NET                                                 |
| :----------------------- | :---------------------------------------------------------- | :------------------------------------ | :----------------------------------------------------------- |
| `sbyte`                  | De -128 a 127                                               | Entero de 8 bits con signo            | [System.SByte](https://learn.microsoft.com/es-es/dotnet/api/system.sbyte) |
| `byte`                   | De 0 a 255                                                  | Entero de 8 bits sin signo            | [System.Byte](https://learn.microsoft.com/es-es/dotnet/api/system.byte) |
| `short`                  | De -32 768 a 32 767                                         | Entero de 16 bits con signo           | [System.Int16](https://learn.microsoft.com/es-es/dotnet/api/system.int16) |
| `ushort`                 | De 0 a 65.535                                               | Entero de 16 bits sin signo           | [System.UInt16](https://learn.microsoft.com/es-es/dotnet/api/system.uint16) |
| `int`                    | De -2.147.483.648 a 2.147.483.647                           | Entero de 32 bits con signo           | [System.Int32](https://learn.microsoft.com/es-es/dotnet/api/system.int32) |
| `uint`                   | De 0 a 4.294.967.295                                        | Entero de 32 bits sin signo           | [System.UInt32](https://learn.microsoft.com/es-es/dotnet/api/system.uint32) |
| `long`                   | De -9.223.372.036.854.775.808 a 9.223.372.036.854.775.807   | Entero de 64 bits con signo           | [System.Int64](https://learn.microsoft.com/es-es/dotnet/api/system.int64) |
| `ulong`                  | De 0 a 18.446.744.073.709.551.615                           | Entero de 64 bits sin signo           | [System.UInt64](https://learn.microsoft.com/es-es/dotnet/api/system.uint64) |
| `nint`                   | Depende de la plataforma (calculada en tiempo de ejecución) | Entero de 64 bits o 32 bits con signo | [System.IntPtr](https://learn.microsoft.com/es-es/dotnet/api/system.intptr) |
| `nuint`                  | Depende de la plataforma (calculada en tiempo de ejecución) | Entero de 64 bits o 32 bits sin signo | [System.UIntPtr](https://learn.microsoft.com/es-es/dotnet/api/system.uintptr) |

##### 2.2.2. Tipos de punto flotante

| Palabra clave/tipo de C# | Intervalo aproximado              | Precisión                          | Tamaño   | Tipo de .NET                                                 |
| :----------------------- | :-------------------------------- | :--------------------------------- | :------- | :----------------------------------------------------------- |
| `float`                  | De ±1,5 x 10-45 a ±3,4 x 1038     | De 6 a 9 dígitos aproximadamente   | 4 bytes  | [System.Single](https://learn.microsoft.com/es-es/dotnet/api/system.single) |
| `double`                 | De ±5,0 × 10−324 a ±1,7 × 10308   | De 15 a 17 dígitos aproximadamente | 8 bytes  | [System.Double](https://learn.microsoft.com/es-es/dotnet/api/system.double) |
| `decimal`                | De ±1,0 x 10-28 to ±7,9228 x 1028 | 28-29 dígitos                      | 16 bytes | [System.Decimal](https://learn.microsoft.com/es-es/dotnet/api/system.decimal) |

```c#
internal class Program
{
    private static void Main(string[] args)
    {
        var a = 12.3;
        double b = 12.3;

        Console.WriteLine($"El valor de a es = {a} ");
        Console.WriteLine($"El valor de a es = {b} ");

    }
}
```

> Ejecucion del programa
>
> **dotnet run**

##### 2.2.3. Literales reales

El tipo de un literal real viene determinado por su sufijo, como se indica a continuación:

- El literal sin sufijo o con el sufijo d o D es del tipo doublé
- El literal con el sufijo f o F es del tipo float
- El literal con el sufijo m o M es del tipo decimal

```c#
internal class Program
{
    private static void Main(string[] args)
    {
        double d = 3D;
        d = 4d;
        d = 3.934_001;
        Console.WriteLine($" {d}");

        float f = 3_000.5F;
        f = 5.4f;
        Console.WriteLine($" {f}");

        decimal myMoney = 3_000.5m;
        myMoney = 400.75M;
        Console.WriteLine($" {myMoney}");
    }
}
```

- **double d = 3D;** Se declara una variable **d** de tipo **double** y se le asigna el valor **3D**. El sufijo **D** indica que el número literal es de tipo **double**.
- **d = 4d;** Aquí se actualiza el valor de la variable **d** a **4d**, utilizando el sufijo **d** para indicar que es un **double**.
- **d = 3.934_001;** Esta línea asigna a **d** el valor **934_001**, que es un número decimal representado en notación de punto flotante.
- **WriteLine($"{d}");** Se utiliza la interpolación de cadenas para imprimir el valor de **d** en la consola.
- **float f = 3_000.5F;** Se declara una variable **f** de tipo **float** y se le asigna el valor **5F**. El sufijo **F** indica que el número literal es de tipo **float**.
- **f = 5.4f;** Esta línea actualiza el valor de **f** a **4f**, utilizando el sufijo **f** para indicar que es un **float**.
- **WriteLine($"{f}");** Se utiliza la interpolación de cadenas para imprimir el valor de **f** en la consola.
- **decimal myMoney = 3_000.5m;** Se declara una variable **myMoney** de tipo **decimal** y se le asigna el valor **5m**. El sufijo **m** indica que el número literal es de tipo **decimal**.
- **myMoney = 400.75M;** Aquí se actualiza el valor de **myMoney** a **75M**, utilizando el sufijo **M** para indicar que es un **decimal**.
- **WriteLine($"{myMoney}");** Se utiliza la interpolación de cadenas para imprimir el valor de **myMoney** en la consola.
- En resumen, el código declara variables de tipo **double**, **float** y **decimal**, les asigna valores y luego los imprime en la consola utilizando la interpolación de cadenas.



| Especificador de formato | NOMBRE  | Descripción |
|-------------------------|---------|-------------|
| "C" o "c"             | Moneda  | Resultado: un valor de divisa. |
|                         |         | Compatible con: todos los tipos numéricos. |
|                         |         | Especificador de precisión: número de dígitos decimales. |
|                         |         | Especificador de precisión predeterminado: Definido por `NumberFormatInfo.CurrencyDecimalDigits`. |
|                         |         | Más información: [Especificador de formato de divisa ("C")](#). |

El especificador de formato "C" (divisa) convierte un número en una cadena que representa una cantidad de divisa. El especificador de precisión indica el número deseado de posiciones decimales en la cadena de resultado. Si se omite el especificador de precisión, el número predeterminado de posiciones decimales que se van a usar en los valores de moneda es 2.

**Propiedad NumberFormatInfo.CurrencySymbol** 

Obtiene o establece la cadena que se va a utilizar como símbolo de divisa.

**En el ejemplo siguiente se muestra el símbolo de moneda de la referencia cultural actual y se usa la cadena de formato numérico estándar "C" para dar formato a un valor de moneda.**

```c#
using System.Globalization;
internal class Program
{
    private static void Main(string[] args)
    {
      Decimal value = 106.25m;
      Console.WriteLine("Current Culture: {0}",
                        CultureInfo.CurrentCulture.Name);
      Console.WriteLine("Currency Symbol: {0}",
                        NumberFormatInfo.CurrentInfo.CurrencySymbol);
      Console.WriteLine("Currency Value:  {0:C2}", value);
    }
}
```

**Propiedad NumberFormatInfo.CurrencyDecimalDigits** 

**En el ejemplo siguiente se muestra el efecto de cambiar la propiedad  [CurrencyDecimalDigits](https://learn.microsoft.com/es-es/dotnet/api/system.globalization.numberformatinfo.currencydecimaldigits?view=net-9.0).**

```c#
using System.Globalization;
internal class Program
{
    private static void Main(string[] args)
    {
      // Gets a NumberFormatInfo associated with the en-US culture.
      NumberFormatInfo nfi = new CultureInfo( "en-US", false ).NumberFormat;

      // Displays a negative value with the default number of decimal digits (2).
      Int64 myInt = -1234;
      Console.WriteLine( myInt.ToString( "C", nfi ) );

      // Displays the same value with four decimal digits.
      nfi.CurrencyDecimalDigits = 4;
      Console.WriteLine( myInt.ToString( "C", nfi ) );
    }
}
```

**Desglose del Código:**

```
using System.Globalization;
```

🔹 Se importa el espacio de nombres `System.Globalization`, que permite trabajar con formatos específicos de cultura (`CultureInfo`).

------

```
internal class Program
{
    private static void Main(string[] args)
```

🔹 Se define la clase `Program` con un método `Main`, que es el punto de entrada de la aplicación.

------

**1️⃣ Creación del Formato de Moneda con Cultura `en-US`**

```
// Gets a NumberFormatInfo associated with the en-US culture.
NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;
```

🔹 Se obtiene una instancia de `NumberFormatInfo` basada en la cultura **"en-US"** (**Estados Unidos**).
🔹 `NumberFormatInfo` permite modificar configuraciones de **formato de moneda, separadores de decimales, miles, etc.**
🔹 El segundo parámetro `false` indica que **no** se debe usar `UseUserOverride` (evita configuraciones personalizadas del usuario).

------

**2️⃣ Formateo de un Número Negativo en Formato Moneda**

```
// Displays a negative value with the default number of decimal digits (2).
Int64 myInt = -1234;
Console.WriteLine(myInt.ToString("C", nfi));
```

🔹 Se declara un número entero de 64 bits (`Int64`) con valor **-1234**.
🔹 Se convierte el número a **formato de moneda (`"C"`)** usando la configuración de `nfi` (cultura `en-US`).
🔹 En `en-US`, la moneda por defecto es **dólares estadounidenses (`$`)**, y el formato de moneda estándar usa **2 decimales**.

**🖥️ Salida esperada (formato por defecto, 2 decimales):**

```
($1,234.00)
```

------

**3️⃣ Modificación de los Decimales en el Formato de Moneda**

```
nfi.CurrencyDecimalDigits = 4;
Console.WriteLine(myInt.ToString("C", nfi));
```

🔹 **Se cambia la cantidad de decimales de la moneda a 4.**
🔹 Ahora, al volver a convertir el número `myInt` a moneda (`"C"`), se mostrarán **4 decimales en lugar de 2**.

**🖥️ Salida esperada (modificado a 4 decimales):**

```
($1,234.0000)
```

------

**🔹 Resumen de la Ejecución**

| Código                                                       | Salida esperada (`en-US`) |
| ------------------------------------------------------------ | ------------------------- |
| `Console.WriteLine(myInt.ToString("C", nfi));`               | **($1,234.00)**           |
| `nfi.CurrencyDecimalDigits = 4;`   `Console.WriteLine(myInt.ToString("C", nfi));` | **($1,234.0000)**         |

**🎯 Conclusión**

✅ **`NumberFormatInfo`** permite personalizar el formato de moneda según la cultura.
✅ **`CurrencyDecimalDigits`** define el número de decimales en el formato monetario.
✅ Se puede usar **diferentes culturas** (`fr-FR`, `ja-JP`, `es-ES`, etc.) para cambiar el símbolo de moneda y el separador decimal.

**Propiedad NumberFormatInfo.CurrencyDecimalSeparator** 

En el ejemplo siguiente se muestra el efecto de cambiar la propiedad  [CurrencyDecimalSeparator](https://learn.microsoft.com/es-es/dotnet/api/system.globalization.numberformatinfo.currencydecimalseparator?view=net-9.0) .

```c#
using System.Globalization;
internal class Program
{
    private static void Main(string[] args)
    {
      NumberFormatInfo nfi = new CultureInfo( "en-US", false ).NumberFormat;

      // Displays a value with the default separator (".").
      Int64 myInt = 123456789;
      Console.WriteLine( myInt.ToString( "C", nfi ) );

      // Displays the same value with a blank as the separator.
      nfi.CurrencyDecimalSeparator = " ";
      Console.WriteLine( myInt.ToString( "C", nfi ) );
    }
}
```

**Desglose del Código**

```
using System.Globalization;
```

🔹 Se importa `System.Globalization`, que permite trabajar con configuraciones regionales (`CultureInfo`).

------

```
internal class Program
{
    private static void Main(string[] args)
```

🔹 Se define la clase `Program` con el método `Main`, que es el punto de entrada de la aplicación.

------

**1️⃣ Configuración de `NumberFormatInfo` con `en-US`**

```
NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;
```

🔹 Se obtiene una instancia de `NumberFormatInfo` basada en la cultura **"en-US"** (**Estados Unidos**).
🔹 `NumberFormatInfo` permite modificar configuraciones de **formato de moneda, separadores de decimales, separadores de miles, etc.**
🔹 El parámetro `false` evita usar configuraciones personalizadas del usuario.

------

**2️⃣ Mostrar un Número con el Formato de Moneda por Defecto**

```
// Displays a value with the default separator (".").
Int64 myInt = 123456789;
Console.WriteLine(myInt.ToString("C", nfi));
```

🔹 Se define un número `myInt = 123456789` (**sin decimales**).
🔹 Se imprime usando **`ToString("C", nfi)`**, que convierte el número a **formato de moneda** en `en-US`.
🔹 En `en-US`, el separador decimal predeterminado es **"." (punto)**.

**🖥️ Salida esperada en consola (por defecto, `en-US` con `.` como separador decimal):**

```
$123,456,789.00
```

🏷 **Explicación del formato:**

- **$** → Símbolo de dólar (`en-US`).
- **,** → Separador de miles (`123,456,789`).
- **.** → Separador decimal (`.00` porque `en-US` usa 2 decimales por defecto en moneda).

------

**3️⃣ Cambiar el Separador Decimal a un Espacio en Blanco**

```
// Displays the same value with a blank as the separator.
nfi.CurrencyDecimalSeparator = " ";
Console.WriteLine(myInt.ToString("C", nfi));
```

🔹 **Se modifica el separador decimal (`CurrencyDecimalSeparator`) para que sea un espacio en blanco `" "` en lugar de `"."`.**
🔹 Cuando se vuelve a imprimir el número en formato moneda, en lugar de **"123,456,789.00"**, ahora mostrará **"123,456,789 00"**.

**🖥️ Salida esperada en consola (con espacio en blanco como separador decimal):**

```
$123,456,789 00
```

🏷 **Explicación del nuevo formato:**

- **$** → Se mantiene el símbolo de dólar.
- **,** → Se mantiene el separador de miles.
- **(espacio en blanco)** → Ahora reemplaza al punto decimal.

------

**🔹 Resumen de la Ejecución**

| Código                                                       | Salida esperada (`en-US`) |
| ------------------------------------------------------------ | ------------------------- |
| `Console.WriteLine(myInt.ToString("C", nfi));` (por defecto) | **$123,456,789.00**       |
| `nfi.CurrencyDecimalSeparator = " ";`   `Console.WriteLine(myInt.ToString("C", nfi));` | **$123,456,789 00**       |

------

**🎯 Conclusión**

✅ **`NumberFormatInfo`** permite personalizar el separador decimal en formatos de moneda.
✅ **`CurrencyDecimalSeparator`** se puede modificar para usar **puntos, comas, espacios u otros caracteres**.
✅ **Ejemplo práctico:** Se puede usar `" "` en lugar de `"."` si se necesita un formato especial en ciertas regiones.



```c#
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        decimal value = 123.456m;
        Console.OutputEncoding = System.Text.Encoding.UTF8; // Asegurar compatibilidad con caracteres especiales

        Console.WriteLine($"{value.ToString("C3", new CultureInfo("en-US"))}");  // $123.46
        Console.WriteLine($"{value.ToString("C", new CultureInfo("fr-FR"))}");  // 123,46 €
        Console.WriteLine($"{value.ToString("C", new CultureInfo("ja-JP"))}");       // ¥123

        Console.WriteLine($"${value.ToString("C3", new CultureInfo("en-US"))}");  // $123.456
        Console.WriteLine($"{value.ToString("C3", new CultureInfo("fr-FR"))}"); // 123,456 €
        Console.WriteLine($"{value.ToString("C3", new CultureInfo("ja-JP"))}");      // ¥123.456

        Console.WriteLine($"-${value.ToString("C3", new CultureInfo("en-US"))}"); // -$123.46
        Console.WriteLine($"-{value.ToString("C3", new CultureInfo("fr-FR"))}"); // -123,46 €
        Console.WriteLine($"-{value.ToString("C3", new CultureInfo("ja-JP"))}");     // -¥123
    }
}
```

**Especificador de formato decimal (D)**

El especificador de formato "D" (o decimal) convierte un número en una cadena de dígitos decimales (0-9), precedida por un signo menos si el número es negativo. Este formato sólo es compatible con los tipos enteros.

```c#
internal class Program
{
    private static void Main(string[] args)
    {
        int num1 = 1234;
        int num2 = -1234;

        // Formato decimal sin ceros de relleno
        Console.WriteLine(num1.ToString("D"));   // 1234

        // Formato decimal con 6 dígitos, rellenando con ceros a la izquierda
        Console.WriteLine(num2.ToString("D6"));  // -001234
    }
}
```

**Especificador de formato de punto fijo (F)**

El especificador de formato de punto fijo ("F") convierte un número en una cadena con el formato "-ddd.ddd…", donde cada "d" indica un dígito (0-9). La cadena comienza con un signo menos si el número es negativo.

El especificador de precisión indica el número deseado de cifras decimales. Si se omite el especificador de precisión, el número predeterminado de posiciones decimales que se van a usar en valores numéricos es 2.

La cadena de resultado se ve afectada por la información de formato de la referencia cultural actual.

| Especificador de formato | Nombre     | Descripción |
|-------------------------|------------|-------------|
| "F" o "f"              | Punto fijo | Resultado: dígitos integrales y decimales con signo negativo opcional. |
|                         |            | Compatible con: todos los tipos numéricos. |
|                         |            | Especificador de precisión: número de dígitos decimales. |
|                         |            | Especificador de precisión predeterminado: definido por la referencia cultural. |
|                         |            | Más información: [Especificador de formato de punto fijo ("F")](#). |




```c#
using System.Globalization;
internal class Program
{
    private static void Main(string[] args)
    {
        double num1 = 1234.567;
        int num2 = 1234;
        double num3 = -1234.56;
        
        Console.OutputEncoding = System.Text.Encoding.UTF8; // Asegurar compatibilidad con caracteres especiales
        // Formato "F" (Número de punto flotante fijo)
        Console.WriteLine(num1.ToString("F", new CultureInfo("en-US"))); // 1234.57
        Console.WriteLine(num1.ToString("F", new CultureInfo("de-DE"))); // 1234,57

        // Formato "F1" (1 decimal)
        Console.WriteLine(num2.ToString("F1", new CultureInfo("en-US"))); // 1234.0
        Console.WriteLine(num2.ToString("F1", new CultureInfo("de-DE"))); // 1234,0

        // Formato "F4" (4 decimales)
        Console.WriteLine(num3.ToString("F4", new CultureInfo("en-US"))); // -1234.5600
        Console.WriteLine(num3.ToString("F4", new CultureInfo("de-DE"))); // -1234,5600
    }
}
```

**`ToString("F")`** → Formatea el número con 2 decimales por defecto.

**`ToString("F1")`** → Formatea con **1 decimal**.

**`ToString("F4")`** → Formatea con **4 decimales**.

**Diferencia entre culturas:**

- `"en-US"` usa **punto (`.`) como separador decimal**.
- `"de-DE"` usa **coma (`,`) como separador decimal**.




#### 2.3. Palabras claves

Las palabras clave son identificadores reservados predefinidos que tienen un significado especial para el compilador. No podrá utilizarlos como identificadores en el programa a no ser que incluyan `@` como prefijo. Por ejemplo, `@if` es un identificador válido, pero `if` no lo es, porque `if` es una palabra clave.

|     |   |    |   |
|-------------|------------|------------|------------|
| abstract    | event      | namespace  | static     |
| as          | explicit   | new        | string     |
| base        | extern     | null       | struct     |
| bool        | false      | object     | switch     |
| break       | finally    | operator   | this       |
| byte        | fixed      | out        | throw      |
| case        | float      | override   | true       |
| catch       | for        | params     | try        |
| char        | foreach    | private    | typeof     |
| checked     | goto       | protected  | uint       |
| class       | if         | public     | ulong      |
| const       | implicit   | readonly   | unchecked  |
| continue    | in         | ref        | unsafe     |
| decimal     | int        | return     | ushort     |
| default     | interface  | sbyte      | using      |
| delegate    | internal   | sealed     | virtual    |
| do          | is         | short      | void       |
| double      | lock       | sizeof     | volatile   |
| else        | long       | stackalloc | while      |
| enum        |            |            |            |

##### 2.3.1.Palabras clave contextuales

| add        | get      | notnull   | set                                      |
|-----------|---------|----------|-------------------------------------------|
| and       | global  | nuint    | unmanaged (convención de llamada de puntero de función) |
| alias     | group   | on       | unmanaged (restricción de tipo genérico) |
| ascending | init    | or       | value                                    |
| args      | into    | orderby  | var                                      |
| async     | join    | partial (tipo) | when (condición de filtro)         |
| await     | let     | partial (método) | where (restricción de tipo genérico) |
| by        | managed (convención de llamada de puntero de función) | record | where (cláusula de consulta) |
| descending | nameof | remove   | con                                      |
| dynamic   | nint    | select   | yield                                    |
| equals    | not     |          |                                          |
| from      |         |          |                                          |

#### 2.4. Entrada y salida de datos

##### 2.4.1. Salida

Los métodos `Console.WriteLine` y `Console.Write` son usados para imprimir texto en la consola en C#. 

🔹 **`Console.WriteLine()`**

El método `Console.WriteLine()` imprime texto en la consola y agrega un salto de línea (`\n`) automáticamente al final.

Ejemplo:

```c#
Console.WriteLine("Hola, mundo!");
Console.WriteLine("Esto es una nueva línea.");
```

**Nota:** Cada `Console.WriteLine` mueve el cursor a la siguiente línea.

🔹 **`Console.WriteLine`** con Interpolación de Cadenas (`$""`)

```c#
Console.WriteLine($"Hola, {nombre}. Tienes {edad} años.");
```

```c#
internal class Program
{
    private static void Main(string[] args)
    {
      string nombre = "Camila";
      int edad = 25;
      Console.Clear();
      Console.WriteLine($"Hola, {nombre}. Tienes {edad} años.");

    }
}
```

🔹 **`Console.Write()`**

El método `Console.Write()` imprime texto en la consola **sin agregar un salto de línea**.

🏷 Ejemplo:

```c#
Console.Write("Hola");
Console.Write(" ");
Console.Write("mundo!");
```

🔹 **Diferencia Entre `Console.WriteLine` y `Console.Write`**

| Método                       | Comportamiento                                           |
| ---------------------------- | -------------------------------------------------------- |
| `Console.WriteLine("Hola");` | Imprime `"Hola"` y pasa a la siguiente línea.            |
| `Console.Write("Hola");`     | Imprime `"Hola"` y mantiene el cursor en la misma línea. |

🏷 **Ejemplo Comparativo:**

```c#
Console.Write("Esto es ");
Console.Write("un mensaje ");
Console.Write("en la misma línea.");

Console.WriteLine("\n"); // Salto de línea manual

Console.WriteLine("Esto es un mensaje con salto de línea.");
Console.WriteLine("Cada WriteLine está en una nueva línea.");
```

**🏷 Salida en consola:**

```less
Esto es un mensaje en la misma línea.

Esto es un mensaje con salto de línea.
Cada WriteLine está en una nueva línea.
```

##### 2.4.2. Entrada

Las funciones de entrada en C# permiten al usuario proporcionar datos a través del teclado, archivos, bases de datos, formularios web y otros medios.

🔹 **Entrada desde Consola (`Console.ReadLine`, `Console.ReadKey`, `Console.Read`)**

En aplicaciones de consola, estos métodos permiten capturar información del usuario.

🔹 **`Console.ReadLine()` → Lee una línea completa de entrada**

Este método captura una línea de texto ingresada por el usuario y la devuelve como una cadena (`string`).

```c#
Console.Write("Ingrese su nombre: ");
string nombre = Console.ReadLine();
Console.WriteLine($"Hola, {nombre}!");
```

🔹 **`Console.ReadKey()` → Captura una tecla sin necesidad de presionar Enter**

Este método permite leer una sola tecla ingresada sin necesidad de presionar **Enter**.

```
csharpCopiarEditarConsole.WriteLine("Presiona una tecla para continuar...");
ConsoleKeyInfo tecla = Console.ReadKey();
Console.WriteLine($"\nHas presionado: {tecla.Key}");
```

**🏷 Salida :**

```
Presiona una tecla para continuar...
Has presionado: A
```

> 🔖 **Nota:** Si agregas `true` como parámetro (`Console.ReadKey(true);`), la tecla no se mostrará en la consola.

🔹**`Console.Read()` → Lee un solo carácter como entero (`int`)**

Este método captura un solo carácter ingresado y devuelve su código ASCII.

```c#
Console.Write("Ingrese un carácter: ");
int codigoAscii = Console.Read();
Console.WriteLine($"Código ASCII ingresado: {codigoAscii}");
```

**📌 Entrada:** `A`
**📌 Salida:**

```less
Código ASCII ingresado: 65
```

> 🏷 **Nota:** Se debe presionar `Enter` después de ingresar el carácter.

```c#
internal class Program
{
    private static void Main(string[] args)
    {
        // 🔹 1. Entrada de datos: Pedir nombre y edad
        Console.Write("Ingrese su nombre: ");
        string nombre = Console.ReadLine(); // Captura el nombre

        Console.Write("Ingrese su edad: ");
        int edad;
        
        // Verifica que el usuario ingrese un número válido
        while (!int.TryParse(Console.ReadLine(), out edad))
        {
            Console.Write("Edad no válida. Ingrese un número: ");
        }

        // 🔹 2. Salida de datos con interpolación de cadenas
        Console.WriteLine($"\nHola {nombre}, tienes {edad} años.");

        // 🔹 3. Leer un solo carácter
        Console.Write("Presiona cualquier tecla para continuar...");
        Console.ReadKey(); // Captura la tecla presionada

        // 🔹 4. Limpiar la consola y mostrar mensaje final
        Console.Clear();
        Console.WriteLine("¡Gracias por usar este programa! 🚀");
    }
}
```

## Sesión 2 Caracteres de escape y casteo de tipos de datos

### Descripción de la sesión:

En esta sesión, los estudiantes profundizarán en la manipulación y conversión de datos en C#. Aprenderán a utilizar **caracteres de escape** para dar formato a textos, así como a aplicar **conversiones implícitas y explícitas** entre tipos de datos. Se explorarán también los **métodos de conversión** disponibles en .NET (`Convert`, `Parse`, `TryParse`) y se reforzará el uso correcto de los **operadores matemáticos, de asignación, comparación e incremento/decremento**, así como funciones avanzadas provistas por la clase `Math`.

### Objetivos de la sesión:

- Comprender y aplicar los principales **caracteres de escape** en C# para formatear salidas.
- Realizar correctamente **conversiones entre tipos de datos**, diferenciando entre implícitas, explícitas y seguras.
- Utilizar correctamente métodos como `Convert`, `Parse` y `TryParse`.
- Aplicar operadores matemáticos, lógicos, de comparación y asignación en expresiones y condiciones.
- Utilizar funciones matemáticas de la clase `Math` para cálculos comunes.

### Resultados esperados:

Al finalizar esta sesión, el estudiante será capaz de:

✅ Usar caracteres de escape (`\n`, `\t`, `\\`, `\"`, etc.) en salidas de texto.

✅ Interpretar códigos Unicode y utilizarlos dentro de cadenas.

✅ Aplicar conversiones implícitas y explícitas entre tipos numéricos.

✅ Usar los métodos `Convert.ToX()`, `Parse()` y `TryParse()` para convertir datos con seguridad.

✅ Dominar operadores aritméticos y la jerarquía de evaluación de expresiones.

✅ Utilizar operadores de incremento, decremento y asignación combinada.

✅ Aplicar operadores de comparación y lógicos en estructuras condicionales.

✅ Emplear funciones matemáticas como `Math.Sqrt`, `Math.Pow`, `Math.Abs`, entre otras.

### 2.5. Caracteres de escape

Los **caracteres de escape** son combinaciones especiales de caracteres precedidos por una barra invertida (`\`), que permiten insertar caracteres no imprimibles o especiales en una cadena de texto.

Se utilizan para representar elementos como saltos de línea, tabulaciones, comillas y otros símbolos dentro de una cadena.

#### 2.5.1. Lista de Caracteres de Escape en C#

| Caracter | Descripción                                        |
| -------- | -------------------------------------------------- |
| `\n`     | Nueva línea (salto de línea)                       |
| `\t`     | Tabulación horizontal                              |
| `\r`     | Retorno de carro (usado en Windows junto con `\n`) |
| `\\`     | Barra invertida (`\`)                              |
| `\'`     | Comilla simple (`'`)                               |
| `\"`     | Comilla doble (`"`)                                |
| `\b`     | Retroceso (Backspace)                              |
| `\f`     | Salto de página                                    |
| `\v`     | Tabulación vertical                                |
| `\0`     | Carácter nulo (null)                               |
| `\uXXXX` | Unicode (carácter basado en un código hexadecimal) |
| `\xXX`   | Código ASCII en hexadecimal                        |

1️⃣ `\n` - Nueva línea

```
Console.WriteLine("Hola, mundo!\nBienvenido a C#.");
```

```c#
Hola, mundo!
Bienvenido a C#.
```

2️⃣ `\t` - Tabulación (Espacios extra)

```
Console.WriteLine("Nombre:\tJose Manuel");
Console.WriteLine("Edad:\t25");
```

3️⃣ `\\` - Barra invertida

```
Console.WriteLine("Ruta en Windows: C:\\Archivos de Programa\\MiApp");
```

> Ruta en Windows: C:\Archivos de Programa\MiApp

4️⃣ `\'` - Comilla simple y `\"` - Comilla doble

```c#
Console.WriteLine("Ella dijo: \"C# es genial!\"");
Console.WriteLine("Caracter: \'A\'");
```

> Ella dijo: "C# es genial!"
> Caracter: 'A'

5️⃣ `\b` - Retroceso (Elimina el carácter anterior)

```c#
Console.WriteLine("Hola\b Mundo!");  // Borra la "a"
```

> Hol Mundo!

6️⃣ `\r` - Retorno de carro (Reemplaza lo anterior en la misma línea)

```c#
Console.Write("Primera línea\rSegunda línea");
```

> Segunda línea

7️⃣ `\0` - Carácter Nulo (Null)

```c#
string texto = "Hola\0Mundo";
Console.WriteLine(texto);
Console.WriteLine("Longitud real: " + texto.Length);
```

> HolaMundo
> Longitud real: 9  // La longitud real no incluye el carácter nulo

8️⃣ `\uXXXX` - Unicode

```c#
Console.WriteLine("\u2665 Esto es un corazón!");
```

> ♥ Esto es un corazón!

🏷 **Tabla de Caracteres Unicode Comunes**

| Código   | Carácter | Descripción            |
| -------- | -------- | ---------------------- |
| `\u0020` | ``       | Espacio                |
| `\u0021` | `!`      | Signo de exclamación   |
| `\u0022` | `"`      | Comillas dobles        |
| `\u0023` | `#`      | Símbolo numeral        |
| `\u0024` | `$`      | Signo de dólar         |
| `\u0025` | `%`      | Porcentaje             |
| `\u0026` | `&`      | Ampersand              |
| `\u0027` | `'`      | Comilla simple         |
| `\u0028` | `(`      | Paréntesis izquierdo   |
| `\u0029` | `)`      | Paréntesis derecho     |
| `\u002A` | `*`      | Asterisco              |
| `\u002B` | `+`      | Signo más              |
| `\u002C` | `,`      | Coma                   |
| `\u002D` | `-`      | Guion                  |
| `\u002E` | `.`      | Punto                  |
| `\u002F` | `/`      | Barra inclinada        |
| `\u003A` | `:`      | Dos puntos             |
| `\u003B` | `;`      | Punto y coma           |
| `\u003C` | `<`      | Menor que              |
| `\u003D` | `=`      | Igual                  |
| `\u003E` | `>`      | Mayor que              |
| `\u003F` | `?`      | Signo de interrogación |
| `\u0040` | `@`      | Arroba                 |
| `\u005B` | `[`      | Corchete izquierdo     |
| `\u005C` | `\`      | Barra invertida        |
| `\u005D` | `]`      | Corchete derecho       |
| `\u005E` | `^`      | Circunflejo            |
| `\u005F` | `_`      | Guion bajo             |
| `\u0060` | ```      | Acento grave           |
| `\u007B` | `{`      | Llave izquierda        |
| `\u007C` | `        | `                      |
| `\u007D` | `}`      | Llave derecha          |
| `\u007E` | `~`      | Tilde (~)              |

------

🏷 **Símbolos Especiales y Matemáticos**

| Código   | Carácter | Descripción          |
| -------- | -------- | -------------------- |
| `\u00A9` | ©        | Símbolo de copyright |
| `\u00AE` | ®        | Marca registrada     |
| `\u2122` | ™        | Marca comercial      |
| `\u2660` | ♠        | Pica                 |
| `\u2663` | ♣        | Trébol               |
| `\u2665` | ♥        | Corazón              |
| `\u2666` | ♦        | Diamante             |
| `\u00B1` | ±        | Más-menos            |
| `\u00D7` | ×        | Multiplicación       |
| `\u00F7` | ÷        | División             |
| `\u221E` | ∞        | Infinito             |
| `\u03C0` | π        | Pi                   |
| `\u221A` | √        | Raíz cuadrada        |
| `\u222B` | ∫        | Integral             |
| `\u2248` | ≈        | Aproximado           |

------

🏷 **Letras Griegas y Científicas**

| Código   | Carácter | Descripción |
| -------- | -------- | ----------- |
| `\u03B1` | α        | Alfa        |
| `\u03B2` | β        | Beta        |
| `\u03B3` | γ        | Gama        |
| `\u03B4` | δ        | Delta       |
| `\u03B5` | ε        | Épsilon     |
| `\u03B7` | η        | Eta         |
| `\u03B8` | θ        | Theta       |
| `\u03BB` | λ        | Lambda      |
| `\u03BC` | μ        | Mi          |
| `\u03C1` | ρ        | Rho         |
| `\u03C3` | σ        | Sigma       |
| `\u03C4` | τ        | Tau         |
| `\u03C9` | ω        | Omega       |

------

🏷 **Caras y Emoticones Unicode**

| Código   | Carácter | Descripción      |
| -------- | -------- | ---------------- |
| `\u263A` | ☺        | Carita sonriente |
| `\u2639` | ☹        | Carita triste    |
| `\u263C` | ☼        | Sol              |
| `\u2602` | ☂        | Paraguas         |
| `\u2709` | ✉        | Sobre de carta   |

------

🏷 **Ejemplo de Uso en C#**

Puedes usar caracteres Unicode en C# con `\uXXXX` dentro de una cadena:

```c#
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Símbolos Unicode en C#:");
        Console.WriteLine("\u2665 Corazón");
        Console.WriteLine("\u221E Infinito");
        Console.WriteLine("\u03C0 Pi");
        Console.WriteLine("\u263A Carita feliz");
        Console.WriteLine("\u00A9 Copyright 2024");
    }
}
```

**🏷 Salida en consola:**

```less
Símbolos Unicode en C#:
♥ Corazón
∞ Infinito
π Pi
☺ Carita feliz
© Copyright 2024
```

🏷 Alternativa: **Cadenas Verbatim (`@""`)**

Si no quieres usar caracteres de escape, puedes usar cadenas verbatim con `@`, que ignoran `\` como escape:

```c#
Console.WriteLine(@"Ruta en Windows: C:\Archivos de Programa\MiApp");
```

**🏷 Salida en consola:**

```less
Ruta en Windows: C:\Archivos de Programa\MiApp
```

🏷 **Nota:** No se necesitan dobles barras invertidas (`\\`).

Los caracteres de escape son fundamentales para manejar texto en C#. Permiten: ✅ Formatear texto correctamente (`\n`, `\t`)
✅ Incluir caracteres especiales (`\\`, `\'`, `\"`)
✅ Manipular visualmente la salida (`\b`, `\r`)
✅ Representar caracteres Unicode (`\uXXXX`)

### 2.7. Conversión de tipos de datos

En C#, se pueden realizar conversiones entre diferentes tipos de datos utilizando diferentes métodos y operadores proporcionados por el lenguaje. En C#, se pueden realizar las siguientes conversiones de tipos:

- **Conversiones implícitas**: no se requiere ninguna sintaxis especial porque la conversión siempre es correcta y no se perderá ningún dato. Los ejemplos incluyen conversiones de tipos enteros más pequeños a más grandes, y conversiones de clases derivadas a clases base.
- **Conversiones explícitas**: las conversiones explícitas requieren una [expresión Cast](https://learn.microsoft.com/es-es/dotnet/csharp/language-reference/operators/type-testing-and-cast#cast-expression). La conversión es necesaria si es posible que se pierda información en la conversión, o cuando es posible que la conversión no sea correcta por otros motivos. Entre los ejemplos típicos están la conversión numérica a un tipo que tiene menos precisión o un intervalo más pequeño, y la conversión de una instancia de clase base a una clase derivada.
- **Conversiones definidas por el usuario**: las conversiones definidas por el usuario se realizan por medio de métodos especiales que se pueden definir para habilitar las conversiones explícitas e implícitas entre tipos personalizados que no tienen una relación de clase base-clase derivada. Para obtener más información, vea [Operadores de conversión definidos por el usuario](https://learn.microsoft.com/es-es/dotnet/csharp/language-reference/operators/user-defined-conversion-operators).
- **Conversiones con clases del asistente**: para realizar conversiones entre tipos no compatibles, como enteros y objetos [DateTime](https://learn.microsoft.com/es-es/dotnet/api/system.datetime), o cadenas hexadecimales y matrices de bytes puede usar la clase [System.BitConverter](https://learn.microsoft.com/es-es/dotnet/api/system.bitconverter), la clase [System.Convert](https://learn.microsoft.com/es-es/dotnet/api/system.convert) y los métodos Parse de los tipos numéricos integrados, como [Int32.Parse](https://learn.microsoft.com/es-es/dotnet/api/system.int32.parse). Para obtener más información, consulte Procedimiento Convertir una matriz de bytes en un valor int, Procedimiento Convertir una cadena en un número y Procedimiento Convertir cadenas hexadecimales en tipos numéricos.

#### 2.7.1. Conversiones implícitas

Para los tipos numéricos integrados, se puede realizar una conversión implícita cuando el valor que se va a almacenar se puede encajar en la variable sin truncarse ni redondearse. Para los tipos enteros, esto significa que el intervalo del tipo de origen es un subconjunto apropiado del intervalo para el tipo de destino. Por ejemplo, una variable de tipo long (entero de 64 bits) puede almacenar cualquier valor que un tipo int (entero de 32 bits) pueda almacenar. En el ejemplo siguiente, el compilador convierte de forma implícita el valor de num en la parte derecha a un tipo long antes de asignarlo a bigNum.

![](https://i.ibb.co/5yHwWsT/image.png)

🏷 **Ejemplo de Conversión Implícita**

```c#
int numeroEntero = 100;
double numeroDecimal = numeroEntero; // Conversión implícita de int a double

Console.WriteLine(numeroDecimal); // Salida: 100
```

📌 **Explicación:** `int` → `double` es seguro porque `double` puede almacenar valores enteros sin pérdida.

🏷 **Otras Conversión Implícitas Comunes**

```c#
byte numByte = 50;
int numInt = numByte;  // ✅ byte → int (Seguro)
float numFloat = numInt;  // ✅ int → float (Seguro)
long numLong = numInt; // ✅ int → long (Seguro)
```

✅ **C# realiza estas conversiones automáticamente porque no hay riesgo de pérdida de datos.**

### 2.8. Conversiones Explícitas

🏷 **Ejemplo de Conversión Explícita**

```c#
double numeroDecimal = 9.7;
int numeroEntero = (int) numeroDecimal; // Conversión explícita (Casting)
Console.WriteLine(numeroEntero); // Salida: 9 (se pierde la parte decimal)
```

📌 **Explicación:**

- `double` a `int` **NO es seguro** porque `int` no tiene decimales.
- Se usa `(int)` **para forzar** la conversión.
- **Se pierde la parte decimal** (`9.7` → `9`).

🏷 **Otras Conversiones Explícitas Comunes**

```c#
long numLong = 100000;
int numInt = (int)numLong;  // ⚠️ Puede perder datos si el número es muy grande
float numFloat = 12.34f;
int numInt2 = (int)numFloat;  // ⚠️ Pierde decimales, resultado: 12
```

------

### **2.9 . Métodos de Conversión en C# (`Convert` y `Parse`)**

Si necesitas convertir datos sin usar **casting**, C# ofrece métodos como `Convert.ToInt32()`, `int.Parse()` y `int.TryParse()`.

#### 2.9.1.  **`Convert.ToTipo()` → Conversión Segura**

```c#
double numDouble = 15.75;
int numInt = Convert.ToInt32(numDouble); // Redondea a 16

Console.WriteLine(numInt); // Salida: 16
```

#### 2.9.2. **Diferencia con Casting:**

- `Convert.ToInt32(15.75)` **redondea** a `16`.
- `(int) 15.75` simplemente **trunca** a `15`.

------

#### 2.9.3. **`Parse()` → Para convertir cadenas en números**

```c#
string textoNumero = "123";
int numero = int.Parse(textoNumero);

Console.WriteLine(numero); // Salida: 123
```

⚠️ **Nota:** Si `textoNumero` contiene caracteres no numéricos (`"abc"`), lanzará una **excepción**.

------

#### 2.9.4. **`TryParse()` → Evita Errores**

Si el usuario ingresa datos incorrectos, `TryParse()` evita que el programa falle.

```c#
Usuario = "456";
int numero;

if (int.TryParse(entradaUsuario, out numero))
{
    Console.WriteLine($"Número válido: {numero}");
}
else
{
    Console.WriteLine("Entrada inválida");
}
```

🏷 **Diferencia con `Parse()`:**

- `TryParse()` **NO lanza excepciones** si la conversión falla.
- Retorna `true` si la conversión es exitosa, `false` si falla.

------

#### 2.9.5. **Resumen de Conversión en C#**

| Tipo de Conversión   | Método                         | Ejemplo                      | Notas                            |
| -------------------- | ------------------------------ | ---------------------------- | -------------------------------- |
| **Implícita** ✅      | Automática                     | `int → double`               | Sin riesgo de pérdida            |
| **Explícita** ⚠️      | Casting `(tipo)`               | `(int) 9.7` → `9`            | Puede perder datos               |
| **Convert.ToTipo()** | `Convert.ToInt32()`            | `Convert.ToInt32(15.7) → 16` | Redondea valores                 |
| **Parse()**          | `int.Parse("123")`             | `"123"` → `123`              | ⚠️ Lanza excepción si es inválido |
| **TryParse()**       | `int.TryParse("123", out num)` | `"abc"` → `false`            | ✅ No lanza excepción             |

**Ejemplo**

```c#
internal class Program
{
    private static void Main(string[] args)
    {
        // 🔹 1. Entrada de un número decimal desde la consola
        Console.Write("Ingrese un número decimal: ");
        double numeroDecimal;

        while (!double.TryParse(Console.ReadLine(), out numeroDecimal))
        {
            Console.Write("Entrada inválida. Ingrese un número decimal válido: ");
        }

        // 🔹 2. Conversión Explícita (Casting)
        int numeroEntero = (int)numeroDecimal;  // Convierte double a int (pierde decimales)

        // 🔹 3. Otras conversiones explícitas con casting
        long numeroGrande = 1000000000;   // Un número muy grande
        short numeroPequeño = (short)numeroGrande;  // Puede perder información

        float numeroFlotante = 123.99f;
        byte numeroByte = (byte)numeroFlotante;  // Trunca el número flotante

        // 🔹 4. Mostrar resultados
        Console.WriteLine("\n📌 Resultados de la conversión explícita:");
        Console.WriteLine($"Número original (double): {numeroDecimal}");
        Console.WriteLine($"Convertido a int (pierde decimales): {numeroEntero}");
        Console.WriteLine($"Número largo (long): {numeroGrande} → Convertido a short: {numeroPequeño} (puede haber pérdida)");
        Console.WriteLine($"Número flotante (float): {numeroFlotante} → Convertido a byte: {numeroByte} (trunca el valor)");

        // 🔹 5. Leer una tecla antes de salir
        Console.Write("\nPresiona cualquier tecla para salir...");
        Console.ReadKey();
    }
}
```

### 2.10. Operadores Matemáticos

**Operadores Aritméticos**

| Operador | Descripción      | Ejemplo               | Resultado             |
| -------- | ---------------- | --------------------- | --------------------- |
| `+`      | Suma             | `int suma = 5 + 3;`   | `8`                   |
| `-`      | Resta            | `int resta = 10 - 4;` | `6`                   |
| `*`      | Multiplicación   | `int multi = 7 * 2;`  | `14`                  |
| `/`      | División         | `int div = 9 / 2;`    | `4` (división entera) |
| `%`      | Módulo (Residuo) | `int mod = 10 % 3;`   | `1`                   |

💡 **Nota:** La división entre enteros devuelve un resultado entero, truncando la parte decimal. Para obtener un resultado con decimales, al menos uno de los operandos debe ser `double` o `float`.

**Orden de Precedencia en C#**

De mayor a menor prioridad:

| Nivel | Operadores                   | Descripción                                      | Asociatividad       |
| ----- | ---------------------------- | ------------------------------------------------ | ------------------- |
| 1️⃣     | `()`                         | **Paréntesis** (se evalúan primero)              | Izquierda a Derecha |
| 2️⃣     | `++` `--`                    | **Incremento/Decremento** (postfijo)             | Izquierda a Derecha |
| 3️⃣     | `+` `-` (unario) `!`         | **Signo positivo/negativo**, **Negación lógica** | Derecha a Izquierda |
| 4️⃣     | `*` `/` `%`                  | **Multiplicación, División y Módulo**            | Izquierda a Derecha |
| 5️⃣     | `+` `-`                      | **Suma y Resta**                                 | Izquierda a Derecha |
| 6️⃣     | `<` `<=` `>` `>=`            | **Comparaciones**                                | Izquierda a Derecha |
| 7️⃣     | `==` `!=`                    | **Igualdad y Diferencia**                        | Izquierda a Derecha |
| 8️⃣     | `&&`                         | **AND lógico**                                   | Izquierda a Derecha |
| 9️⃣     | `                            |                                                  | `                   |
| 🔟     | `=` `+=` `-=` `*=` `/=` `%=` | **Asignación**                                   | Derecha a Izquierda |

```c#
internal class Program
{
    private static void Main(string[] args)
    {
         int resultado = 10 + 5 * 2 - 8 / 4; 
        Console.WriteLine(resultado); // 18       
    }
}
```

**📌 Explicación:**

1. Multiplicación (`5 * 2 = 10`) y división (`8 / 4 = 2`) se resuelven primero.
2. Luego se evalúa la suma y resta: `10 + 10 - 2 = 18`.

```c#
internal class Program
{
    private static void Main(string[] args)
    {
        int a = 5, b = 10, c = 15;
        
        int resultado = a + b * c / 5 - 3; 
        Console.WriteLine($"Resultado sin paréntesis: {resultado}");

        int resultadoConParentesis = (a + b) * (c / 5) - 3;
        Console.WriteLine($"Resultado con paréntesis: {resultadoConParentesis}");
    }
}
```

```c#
internal class Program
{
    private static void Main(string[] args)
    {
        // 📌 1️⃣ Operaciones básicas y jerarquía de operadores matemáticos
        int a = 10, b = 5, c = 2;
        int resultado1 = a + b * c - 8 / 4;  // Multiplicación y división primero
        Console.WriteLine($"Resultado1 (10 + 5 * 2 - 8 / 4): {resultado1}"); // 18

        int resultado2 = (a + b) * c - 8 / 4; // Paréntesis alteran el orden
        Console.WriteLine($"Resultado2 ((10 + 5) * 2 - 8 / 4): {resultado2}"); // 26

        // 📌 2️⃣ Operaciones de incremento y decremento
        int x = 5;
        int y = ++x + x--;  // ++x incrementa primero, x-- se evalúa antes de restar
        Console.WriteLine($"y = ++x + x--: {y} (x final: {x})"); // 11 (x = 5)

        // 📌 3️⃣ Operaciones lógicas y relacionales combinadas
        int edad = 20;
        bool tieneLicencia = true;
        bool puedeConducir = (edad >= 18) && tieneLicencia;
        Console.WriteLine($"¿Puede conducir? {puedeConducir}"); // true

        // 📌 4️⃣ Uso de operadores lógicos con relacionales
        int temperatura = 30;
        bool haceFrio = !(temperatura > 15); // Negación lógica
        Console.WriteLine($"¿Hace frío? {haceFrio}"); // false

        // 📌 5️⃣ Uso de operadores de asignación combinados
        int numero = 10;
        numero += 5;  // Equivalente a numero = numero + 5
        numero *= 2;  // Equivalente a numero = numero * 2
        Console.WriteLine($"Número tras operaciones: {numero}"); // 30

        // 📌 6️⃣ Expresión Compleja combinando todo
        int resultadoFinal = ((a * b) / c + x) - (numero % 4) * (y - 2);
        Console.WriteLine($"Resultado final: {resultadoFinal}");
    }
}
```



### 2.11. **Operadores de Asignación**

| Operador | Descripción         | Ejemplo                |
| -------- | ------------------- | ---------------------- |
| `=`      | Asignación          | `int x = 10;`          |
| `+=`     | Suma y asigna       | `x += 5; // x = x + 5` |
| `-=`     | Resta y asigna      | `x -= 3; // x = x - 3` |
| `*=`     | Multiplica y asigna | `x *= 2; // x = x * 2` |
| `/=`     | Divide y asigna     | `x /= 4; // x = x / 4` |
| `%=`     | Módulo y asigna     | `x %= 2; // x = x % 2` |

### 2.12. **Operadores de Incremento y Decremento**

| Operador | Descripción               | Ejemplo | Resultado                              |
| -------- | ------------------------- | ------- | -------------------------------------- |
| `++`     | Incremento en 1 (prefijo) | `++x;`  | Aumenta primero y luego usa el valor   |
| `++`     | Incremento en 1 (sufijo)  | `x++;`  | Usa el valor y luego lo incrementa     |
| `--`     | Decremento en 1 (prefijo) | `--y;`  | Disminuye primero y luego usa el valor |
| `--`     | Decremento en 1 (sufijo)  | `y--;`  | Usa el valor y luego lo decrementa     |

### 2.13.  **Operadores Matemáticos en `Math`**

C# incluye la clase `Math` que proporciona métodos matemáticos avanzados:

| Método                                      | Descripción               | Ejemplo                 | Resultado |
| ------------------------------------------- | ------------------------- | ----------------------- | --------- |
| `Math.Abs(x)`                               | Valor absoluto            | `Math.Abs(-10)`         | `10`      |
| `Math.Pow(x, y)`                            | Potencia                  | `Math.Pow(2, 3)`        | `8.0`     |
| `Math.Sqrt(x)`                              | Raíz cuadrada             | `Math.Sqrt(25)`         | `5.0`     |
| `Math.Round(x)`                             | Redondeo estándar         | `Math.Round(4.7)`       | `5`       |
| `Math.Floor(x)`                             | Redondeo hacia abajo      | `Math.Floor(4.9)`       | `4`       |
| `Math.Ceiling(x)`                           | Redondeo hacia arriba     | `Math.Ceiling(4.1)`     | `5`       |
| `Math.Max(x, y)`                            | Máximo entre dos números  | `Math.Max(10, 20)`      | `20`      |
| `Math.Min(x, y)`                            | Mínimo entre dos números  | `Math.Min(10, 20)`      | `10`      |
| `Math.Sin(x)`, `Math.Cos(x)`, `Math.Tan(x)` | Funciones trigonométricas | `Math.Sin(Math.PI / 2)` | `1.0`     |

### 2.14. Operadores de Comparación

📖 **Lista de Operadores de Comparación**

| Operador | Descripción       | Ejemplo  | Resultado |
| -------- | ----------------- | -------- | --------- |
| `==`     | Igual a           | `5 == 5` | `true`    |
| `!=`     | Diferente de      | `5 != 3` | `true`    |
| `>`      | Mayor que         | `10 > 7` | `true`    |
| `<`      | Menor que         | `4 < 9`  | `true`    |
| `>=`     | Mayor o igual que | `6 >= 6` | `true`    |
| `<=`     | Menor o igual que | `3 <= 5` | `true`    |

### 2.15. Operadores Lógicos

📖 **Lista de Operadores Lógicos**

| Operador | Descripción                                                  | Ejemplo               | Resultado                                                    |
| -------- | ------------------------------------------------------------ | --------------------- | ------------------------------------------------------------ |
| `&&`     | **AND (y lógico)** - Devuelve `true` si ambas expresiones son `true` | `(5 > 3) && (8 < 10)` | `true`                                                       |
| \|\|                     | **OR (o lógico)** - Devuelve `true` si al menos una expresión es `true` |||
| `!`      | **NOT (negación lógica)** - Invierte el valor booleano       | `!(5 > 3)`            | `false`                                                      |

## Sesión 3: Estructuras de control e iterativas

En esta sesión, los estudiantes explorarán las **estructuras de control de flujo** en C#, fundamentales para tomar decisiones y repetir bloques de código. Se abordarán en detalle las **estructuras condicionales** (`if`, `if-else`, `switch`) y las **estructuras iterativas** (`for`, `while`, `do-while`, `foreach`). A través de ejemplos prácticos y ejercicios guiados, se buscará desarrollar la capacidad lógica y analítica necesaria para escribir programas que respondan a diferentes condiciones y repitan acciones dinámicamente.

### Objetivos de la sesión:

- Comprender el uso de **estructuras condicionales** para controlar el flujo de ejecución según condiciones lógicas.
- Aplicar estructuras `if`, `if-else`, `else if`, `switch` y `switch when` en diferentes escenarios.
- Conocer y utilizar las **estructuras de repetición** en C# para automatizar tareas.
- Diferenciar el uso y características de los bucles `for`, `while`, `do-while` y `foreach`.
- Desarrollar lógica de programación para resolver problemas mediante decisiones y repeticiones.

### Resultados esperados:

Al finalizar esta sesión, el estudiante será capaz de:

✅ Escribir condiciones utilizando estructuras `if`, `if-else`, `if-else if-else` y `switch`.

✅ Utilizar operadores lógicos (`&&`, `||`, `!`) en condiciones compuestas.

✅ Emplear el operador ternario `?:` para simplificar decisiones.

✅ Implementar bucles `for`, `while`, `do-while` y `foreach` en problemas reales.

✅ Identificar qué estructura iterativa es más adecuada según el contexto del problema.

✅ Desarrollar programas en C# que tomen decisiones y repitan instrucciones según condiciones variables.

### 2.16. Estructuras de Control: Condicionales

Las estructuras de control en programación son mecanismos o bloques de código que permiten controlar el flujo de ejecución de un programa. Estas estructuras se utilizan para tomar decisiones y repetir bloques de código según ciertas condiciones.

Hay 2 tipos principales de estructuras de control:

- Estructuras de control condicional: Estas estructuras permiten tomar decisiones basadas en una condición. Los bloques de código se ejecutan solo si se cumple la condición especificada. Los ejemplos más comunes de estructuras de control condicional son:
  - La estructura "if" (si): Permite ejecutar un bloque de código solo si una condición es verdadera.
  - La estructura "if-else" (si-sino): Permite ejecutar un bloque de código si una condición es verdadera y otro bloque de código si la condición es falsa.
  - La estructura "switch" (interruptor): Permite seleccionar uno de varios bloques de código para ejecutar, según el valor de una expresión.📖 

#### 2.16.1.  If

En C#, la estructura de control `if` se utiliza para ejecutar un bloque de código únicamente cuando se cumple una condición específica.

**1️⃣ `if` Simple**

```c#
if (condición)
{
    // Código a ejecutar si la condición es verdadera
}
```

**2️⃣ `if` - `else`**

```c#
if (condición)
{
    // Código si la condición es verdadera
}
else
{
    // Código si la condición es falsa
}
```

------

**3️⃣ `if` - `else if` - `else` (Múltiples Condiciones)**

```c#
if (condición1)
{
    // Código si condición1 es verdadera
}
else if (condición2)
{
    // Código si condición2 es verdadera
}
else
{
    // Código si ninguna de las condiciones anteriores se cumple
}
```

**4️⃣ `if` Anidado**

Se pueden anidar múltiples `if` dentro de otros `if`.

```c#
int edad = 25;
bool tieneLicencia = true;

if (edad >= 18)
{
    if (tieneLicencia)
    {
        Console.WriteLine("Puedes conducir.");
    }
    else
    {
        Console.WriteLine("Necesitas una licencia para conducir.");
    }
}
else
{
    Console.WriteLine("Eres menor de edad, no puedes conducir.");
}

```

**5️⃣ `if` con Operadores Lógicos**

Se pueden combinar múltiples condiciones con `&&` (AND) y `||` (OR).

```c#
int edad = 22;
bool estudiante = true;

if (edad >= 18 && estudiante)
{
    Console.WriteLine("Tienes descuento por ser estudiante mayor de edad.");
}

```

6️⃣ **`if` en una sola línea (Operador Ternario `? :`)**

El operador condicional `?:`, conocido como operador ternario, evalúa una expresión booleana y devuelve uno de dos posibles resultados según si la condición es `true` o `false`.

```c#
string mensaje = (edad >= 18) ? "Mayor de edad" : "Menor de edad";
Console.WriteLine(mensaje);

```

#### 2.16.2. Switch

El `switch` en C# es una estructura de control que permite ejecutar diferentes bloques de código según el valor de una variable. Es una alternativa más clara y eficiente que una serie de `if-else if`.

**Sintaxis del `switch`**

```c#
switch (expresión)
{
    case valor1:
        // Código a ejecutar si expresión == valor1
        break;
    case valor2:
        // Código a ejecutar si expresión == valor2
        break;
    default:
        // Código si ningún caso coincide
        break;
}
```

**Importante:**

- Cada `case` **debe terminar con `break`**, a menos que se use una estructura diferente.
- El `default` es **opcional**, pero recomendable para manejar casos no previstos.

**Uso de `switch` con `when` (Filtros en C# 7.0+)**

A partir de C# 7, `switch` permite evaluar condiciones adicionales con `when`.

```c#
internal class Program
{
    private static void Main(string[] args)
    {
        int edad = 20;

        switch (edad)
        {
            case int e when (e < 18):
                Console.WriteLine("Eres menor de edad.");
                break;
            case int e when (e >= 18 && e < 60):
                Console.WriteLine("Eres adulto.");
                break;
            default:
                Console.WriteLine("Eres adulto mayor.");
                break;
        }

    }
}
```

El `switch` evalúa la variable `edad` y clasifica a la persona en **menor de edad**, **adulto** o **adulto mayor** usando `when` para establecer condiciones adicionales.

📌 **Explicación rápida de cada caso:**

1. Si `edad < 18` → Imprime `"Eres menor de edad."`
2. Si `edad >= 18 && edad < 60` → Imprime `"Eres adulto."`
3. Si `edad >= 60` (por defecto) → Imprime `"Eres adulto mayor."`

La variable `e` dentro de cada `case` es una **variable de patrón** que captura el valor de `edad` y lo usa dentro de la condición `when`.

📌 **Explicación paso a paso:**

```c#
case int e when (e < 18):
```

- `int e` → Captura el valor de `edad` en la variable `e`.
- `when (e < 18)` → Evalúa si `e` es menor de 18.

```c#
case int e when (e >= 18 && e < 60):
```

- `int e` captura `edad` en `e`.
- `when (e >= 18 && e < 60)` evalúa si la edad está entre 18 y 59.

### 2.17. Estructuras de Iterativas: Ciclos

Las **estructuras repetitivas** permiten ejecutar un bloque de código varias veces mientras se cumpla una condición.

#### 2.17.1. **Tipos de Bucles en C#**

| Bucle      | Uso Principal                                            | Característica                                |
| ---------- | -------------------------------------------------------- | --------------------------------------------- |
| `for`      | Iteraciones controladas con contador                     | Se ejecuta un número determinado de veces     |
| `while`    | Repetición mientras se cumpla una condición              | Evalúa la condición **antes** de ejecutar     |
| `do-while` | Similar a `while`, pero garantiza al menos una ejecución | Evalúa la condición **después** de ejecutar   |
| `foreach`  | Recorre colecciones (`arrays`, `List<T>`, etc.)          | Itera sobre elementos sin necesidad de índice |

#### 2.17.2. Bucle `for` (Controlado por un Contador)

El **bucle `for`** se usa cuando conocemos el número exacto de iteraciones que deben ejecutarse. Se basa en un **contador** que cambia en cada iteración.

**🖥️ Sintaxis**

```less
for (inicialización; condición; actualización)
{
    // Código que se ejecuta en cada iteración
}

Ejemplo

for (int i = 1; i <= 5; i++)
{
    Console.WriteLine($"Número: {i}");
}

for (int i = 1; i <= 5; i=i+2)
{
    Console.WriteLine($"Número: {i}");
}

for (int i =5; i >= 1; i=i+2)
{
    Console.WriteLine($"Número: {i}");
}

```

**📝 Explicación de sus partes**

- **Inicialización:** Se ejecuta **una sola vez** antes de que comience el bucle (ejemplo: `int i = 0`).
- **Condición:** Se evalúa **antes de cada iteración**. Si es `true`, el bloque de código se ejecuta; si es `false`, el bucle termina.
- **Actualización:** Se ejecuta **al final de cada iteración** (ejemplo: `i++`).

#### 2.17.3. Bucle `while` (Ejecución Basada en una Condición)

El **bucle `while`** se usa cuando **no sabemos cuántas veces** debe repetirse el código, pero queremos que se ejecute **mientras se cumpla una condición**.

**🖥️ Sintaxis**

```c#
while (condición)
{
    // Código que se ejecuta mientras la condición sea verdadera
}
```

**📝 Explicación**

- La **condición** se evalúa **antes** de cada iteración.
- Si la condición es `true`, el código dentro del `while` se ejecuta.
- Si la condición es `false`, el bucle termina.

#### 2.17.4. Bucle `do..while` (Ejecución Basada en una Condición)

En **C#**, el ciclo `do..while` es una estructura de control de flujo que ejecuta un bloque de código al menos una vez y luego evalúa una condición para determinar si debe repetirse.

```c#
do
{
    // Bloque de código que se ejecuta al menos una vez
} while (condición);

```

**Características principales:**

1. **Ejecución garantizada al menos una vez**: A diferencia de `while`, el bloque de código dentro de `do` siempre se ejecuta al menos una vez, ya que la condición se evalúa después de la primera iteración.
2. **Verificación de condición al final**: Después de ejecutar el bloque de código, el `while` evalúa la condición. Si es `true`, el ciclo se repite; si es `false`, el bucle se detiene.

#### 2.17.5. Bucle `foreach` (Ejecución Basada en una Condición)

El ciclo **`foreach`** en **C#** es una estructura de control que permite recorrer de manera sencilla los elementos de una colección o arreglo, sin necesidad de gestionar índices manualmente.

**Diferencias entre `for` y `foreach`**

| Característica            | `for`                                                | `foreach`                                     |
| ------------------------- | ---------------------------------------------------- | --------------------------------------------- |
| Uso de índice             | Sí, se necesita un índice (`i`)                      | No, accede directamente a los elementos       |
| Modificación de elementos | Sí, es posible modificar los valores en la colección | No se pueden modificar elementos directamente |
| Simplicidad               | Más complejo, pero flexible                          | Más simple y legible para iterar              |

------

**Cuándo usar `foreach`**

✅ Cuando se quiere recorrer una colección sin preocuparse por los índices.
✅ Cuando se necesita escribir código más limpio y legible.
✅ Cuando no se requiere modificar los elementos de la colección.

### Sesión 4 Funciones

#### 2.18 ¿Qué son las funciones en C#?

En C# se llaman **métodos**. Son bloques de código reutilizable que realizan una tarea específica y pueden devolver un valor.

```bash
[modificadores] [tipo_retorno] NombreMetodo([parámetros])
{
    // Código del método
    return valor; // Si retorna algo
}
```

##### Propósitos fundamentales:

- **Abstracción**: Ocultar la complejidad de implementación
- **Reutilización**: Evitar duplicación de código
- **Modularidad**: Dividir problemas complejos en partes manejables
- **Mantenibilidad**: Facilitar cambios y correcciones

#### 2.19 Tipos de métodos:

##### Métodos que retornan valor:

**Concepto**: Métodos que devuelven un resultado al código que los invoca

**Propósito**: Computar y devolver información

**Principio**: Función matemática - entrada → procesamiento → salida

**Características**:

- Deben contener al menos una declaración `return`
- El tipo de retorno debe coincidir con el valor devuelto
- Pueden tener múltiples puntos de retorno

```c#
// Método simple que suma dos números
public int Sumar(int a, int b)
{
    return a + b;
}

// Método que retorna string
public string ObtenerSaludo(string nombre)
{
    return $"Hola, {nombre}!";
}

// Método que retorna bool
public bool EsPar(int numero)
{
    return numero % 2 == 0;
}
```

##### Métodos void (sin retorno):

**Concepto**: Métodos que no devuelven ningún valor

**Propósito**: Realizar acciones o efectos secundarios

**Principio**: Procedimiento - ejecuta acciones sin retorno

**Características**:

- No requieren declaración `return` (opcional `return;` vacío)
- Se usan para operaciones de salida, modificación de estado, etc.

```c#
public void MostrarMensaje(string mensaje)
{
    Console.WriteLine(mensaje);
}

public void ImprimirTabla(int numero)
{
    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine($"{numero} x {i} = {numero * i}");
    }
}
```

#### 2.20 Tipos de parámetros:

##### Parámetros por valor (por defecto):

**Semántica**: Paso por copia

**Principio**: El método recibe una copia del valor original

**Inmutabilidad**: Los cambios no afectan la variable original

**Aplicabilidad**: Tipos de valor (int, bool, struct) y referencias de objetos

```c#
public void CambiarValor(int x)
{
    x = 100; // No afecta la variable original
}
```

> #### Comportamiento en memoria:
>
> - Para tipos valor: Se copia el valor completo
> - Para tipos referencia: Se copia la referencia (no el objeto)

##### Parámetros por referencia (ref):

- **Semántica**: Paso por alias
- **Principio**: El parámetro es un alias de la variable original
- **Mutabilidad**: Los cambios SÍ afectan la variable original
- **Requisito**: La variable debe estar inicializada antes de pasarla

Uso:

- Cuando se necesita que el método modifique la variable original
- Para evitar copias costosas de estructuras grandes
- Para implementar métodos que "retornen" múltiples valores

```c#
public void CambiarPorReferencia(ref int x)
{
    x = 100; // SÍ afecta la variable original
}
// Uso:
int numero = 5;
CambiarPorReferencia(ref numero);
// numero ahora es 100
```

##### Parámetros de salida (out):

**Semántica**: Paso por referencia con inicialización obligatoria

**Principio**: El método DEBE asignar un valor al parámetro

**Inicialización**: No requiere inicialización previa

**Propósito**: Métodos que devuelven múltiples valores

```c#
public bool TryParsear(string texto, out int resultado)
{
    return int.TryParse(texto, out resultado);
}
// Uso:
if (TryParsear("123", out int valor))
{
    Console.WriteLine($"Valor: {valor}");
}
```

**Diferencia con ref:**

- `ref`: Variable debe estar inicializada, método puede leer valor anterior
- `out`: Variable no necesita inicialización, método DEBE asignar valor

##### Parámetros opcionales:

- **Flexibilidad**: Permiten sobrecarga implícita
- **Valores por defecto**: Se evalúan en tiempo de compilación
- **Principio**: Simplifican la API reduciendo sobrecargas explícitas

Restricciones:

- Deben estar al final de la lista de parámetros
- El valor por defecto debe ser una expresión constante

```c#
public string CrearSaludo(string nombre, string prefijo = "Sr.", bool formal = true)
{
    if (formal)
        return $"{prefijo} {nombre}";
    else
        return $"Hola {nombre}";
}

// Usos:
CrearSaludo("Juan");                    // "Sr. Juan"
CrearSaludo("Juan", "Dr.");            // "Dr. Juan"
CrearSaludo("Juan", formal: false);    // "Hola Juan"
```

##### Parámetros variables (params):

**Variabilidad**: Acepta cantidad variable de argumentos

**Implementación**: Se convierte internamente en array

**Flexibilidad**: Simplifica llamadas con múltiples parámetros del mismo tipo

**Restricción**: Solo uno por método y debe ser el último parámetro

```c#
public int SumarTodos(params int[] numeros)
{
    int suma = 0;
    foreach (int numero in numeros)
    {
        suma += numero;
    }
    return suma;
}

// Usos:
SumarTodos(1, 2, 3);           // 6
SumarTodos(1, 2, 3, 4, 5);     // 15
```

###### ⚠️ Reglas importantes

- Solo puede haber **un parámetro `params`** por método.
- Debe ser el **último parámetro** de la lista.
- Internamente, `params` se trata como un **array** del tipo especificado.

```c#
public void SaludarPersonas(params string[] nombres)
{
    foreach (string nombre in nombres)
        Console.WriteLine($"Hola, {nombre}!");
}
SaludarPersonas("Ana", "Luis", "Johlver");
```



#### 2.21 Modificadores de acceso

Son **palabras clave** que determinan **desde dónde puede accederse** a clases, métodos, propiedades y otros miembros. Ayudan a proteger los datos y mantener el código organizado y seguro.

```c#
public class Persona
{
    private string nombre = "Juan";                      // Solo accesible dentro de Persona
    protected int edad = 30;                             // Accesible en clases hijas
    internal string ciudad = "Bogotá";                   // Accesible en el mismo proyecto
    protected internal string pais = "Colombia";         // Proyecto o herencia
    private protected string region = "Andina";          // Solo proyecto y herencia
    public string Apellido = "Pérez";                    // Accesible desde cualquier lugar
}
```

##### **public**

- **Concepto**: Acceso irrestricto
- **Visibilidad**: Desde cualquier ensamblado y contexto
- **Uso**: APIs públicas, interfaces de contrato
- **Principio**: Máxima exposición - usar con cuidado

##### **private**

- **Concepto**: Acceso restringido a la misma clase
- **Visibilidad**: Solo dentro de la clase que lo declara
- **Uso**: Detalles de implementación interna
- **Principio**: Máxima encapsulación - por defecto en clases

##### **protected**

- **Concepto**: Acceso jerárquico
- **Visibilidad**: Clase actual y clases derivadas
- **Uso**: Miembros compartidos en jerarquía de herencia
- **Principio**: Encapsulación con extensibilidad controlada

##### **internal**

- **Concepto**: Acceso a nivel de ensamblado
- **Visibilidad**: Dentro del mismo ensamblado (.dll o .exe)
- **Uso**: APIs internas del proyecto
- **Principio**: Encapsulación a nivel de componente

##### **protected internal**

- **Concepto**: Unión de protected e internal
- **Visibilidad**: Clases derivadas o mismo ensamblado
- **Uso**: Casos específicos de frameworks
- **Principio**: Flexibilidad de acceso combinada

##### **private protected**

- **Concepto**: Intersección de private y protected
- **Visibilidad**: Clases derivadas y mismo ensamblado
- **Uso**: Control granular en jerarquías
- **Principio**: Acceso más restrictivo que protected

#### 2.22 Métodos estáticos:

Un **método estático** es un método que pertenece a la **clase**, no a una instancia de la clase. Es decir, **no necesitas crear un objeto** para usarlo.

**Acceso**: Mediante Clase.metodo()

**Contexto**: No tienen acceso a miembros de instancia

**Principio**: Funciones utilitarias independientes del estado del objeto

**Uso**: Operaciones que no dependen del estado de la instancia

```c#
public static class Utilidades
{
    public static double CalcularArea(double radio)
    {
        return Math.PI * radio * radio;
    }
    
    public static string FormatearMoneda(decimal cantidad)
    {
        return $"${cantidad:N2}";
    }
}

// Uso sin crear instancia:
double area = Utilidades.CalcularArea(5.0);
```

#### 2.23. Sobrecarga de métodos (Overloading):

Es la capacidad de definir múltiples versiones de un método con el **mismo nombre**, pero con **diferente firma** (es decir, diferente número, tipo o posición de los parámetros).

```c#
public class Calculadora
{
    public int Sumar(int a, int b)
    {
        return a + b;
    }
    public double Sumar(double a, double b)
    {
        return a + b;
    }
    public int Sumar(int a, int b, int c)
    {
        return a + b + c;
    }
}
```

#### 2.24 Métodos con expresiones lambda (Expression-bodied)

En C#, los **métodos con expresiones lambda** (también llamados **expression-bodied methods**) son una forma **más concisa y legible** de escribir métodos que **devuelven un valor o ejecutan una única expresión**.

##### 🔹 ¿Qué es una expresión lambda en métodos?

Es una **forma simplificada** de definir métodos, propiedades, constructores o finalizadores que tienen **una única instrucción**.

**Sintaxis**

```c#
tipo_de_retorno NombreMetodo(parámetros) => expresión;
```

Es equivalente a:

```c#
tipo_de_retorno NombreMetodo(parámetros)
{
    return expresión;
}
```

```c#
// Versión tradicional
public int Multiplicar(int a, int b)
{
    return a * b;
}

// Versión con expresión lambda
public int Multiplicar(int a, int b) => a * b;

public bool EsMayorDeEdad(int edad) => edad >= 18;

public void Saludar(string nombre) => Console.WriteLine($"Hola {nombre}");
```

🔸 En propiedades:

```c#
private string nombre;

public string Nombre => nombre.ToUpper();
```

##### 🧠 Ventajas

- Menos líneas de código.
- Mayor legibilidad cuando el método es simple.
- Ideal para getters, utilidades y controladores pequeños.

------

##### ⚠️ Cuándo **NO** usar

- Cuando el método tiene **más de una instrucción**.
- Cuando la lógica necesita validaciones, bucles o estructuras de control complejas.

##### **Ejercicios Básicos**

###### 🧩 **Ejercicio 1: Suma Rápida**

**Propósito:** Practicar expresión lambda con retorno simple.

**Requisito:** Crea una clase `Operaciones` con un método `Sumar` que reciba dos enteros y retorne su suma.

```c#
public class Operaciones
{
    public int Sumar(int a, int b) => // completa con tu código aquí
}
```

Resultado esperado:

```
Operaciones op = new Operaciones();
Console.WriteLine(op.Sumar(3, 7)); // 10
```

###### 🧩 **Ejercicio 2: ¿Es Par?**

**Propósito:** Aplicar expresión lambda en un método que devuelva un valor booleano.

**Requisito:** Crea un método `EsPar` que reciba un número entero y devuelva `true` si es par, `false` si es impar.

```
public bool EsPar(int n) => // completa con tu código aquí
```

🧩 **Ejercicio 3: Saludo personalizado**

**Propósito:** Usar `Console.WriteLine` dentro de un método `void` con `=>`.

**Requisito:** Define un método `Saludar(string nombre)` que imprima `Hola, <nombre>`.

```c#
public void Saludar(string nombre) => //completa con tu código aquí
```

## 🧩 **Ejercicio 4: Edad actual**

**Propósito:** Trabajar con fechas y expresión lambda.

**Requisito:** En la clase `Persona`, crea un método `Edad()` que devuelva la edad actual en años, usando el año de nacimiento.

```c#
public class Persona
{
    public int AnioNacimiento { get; set; }
    public int Edad() => // tu código aquí
}
```

🧩 **Ejercicio 5: Convertir a mayúscula**

**Propósito:** Usar `string` y expresión lambda.

**Requisito:** Crea un método `EnMayuscula(string texto)` que retorne el texto en mayúscula.

```
public string EnMayuscula(string texto) => //completa con tu código aquí
```

#### 2.25 Métodos anónimos y delegados

En C#, **los métodos anónimos** y **los delegados** están estrechamente relacionados y permiten trabajar con programación funcional, es decir, tratar funciones como datos.

##### 🔹 ¿Qué es un delegado?

Un **delegado** es un tipo que representa una referencia a un método con una **firma específica**. Piensa en él como un puntero a función en C o C++.

```c#
public delegate int Operacion(int a, int b);

public class Calculadora
{
    public static int Sumar(int x, int y)
    {
        return x + y;
    }
}
```

```c#
Operacion op = new Operacion(Calculadora.Sumar);
int resultado = op(3, 4); // Resultado: 7
```

##### 🔹 ¿Qué es un método anónimo?

Un **método anónimo** es una manera de definir un método **sin nombre** directamente donde se necesita, generalmente asociado a un delegado.

```c#
Operacion op = delegate(int a, int b)
{
    return a * b;
};

int resultado = op(5, 4); // Resultado: 20

```

```c#
// Delegado
public delegate int Operacion(int a, int b);

// Método anónimo
Operacion suma = delegate(int x, int y) { return x + y; };

// Con lambda
Operacion resta = (x, y) => x - y;
```

##### ✅ Ventajas de los métodos anónimos

- No necesitas declarar un método por separado.
- Muy útiles para operaciones pequeñas y rápidas.
- Se usan mucho con eventos, callbacks y expresiones lambda.

#### 2.26 Métodos genéricos

En C#, los **métodos genéricos** son métodos que permiten definir **parámetros de tipo** (placeholders) que se especifican cuando se llama al método. Esto proporciona **flexibilidad y reutilización** del código sin sacrificar el **tipo de seguridad** (type safety) que ofrece el lenguaje.

##### 🧠 ¿Para qué sirven?

Los métodos genéricos permiten:

- Trabajar con **diferentes tipos de datos** sin duplicar el código.
- Evitar conversiones explícitas (casting).
- Detectar errores en tiempo de compilación gracias a la verificación de tipos.

```c#
public T ObtenerMayor<T>(T a, T b) where T : IComparable<T>
{
    return a.CompareTo(b) > 0 ? a : b;
}

// Uso:
int mayorInt = ObtenerMayor(5, 10);        // 10
string mayorString = ObtenerMayor("a", "z"); // "z"
```



Ejemplo Avanzado

```c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.IO;

#region MÉTODOS GENÉRICOS

// Clase genérica con múltiples restricciones
public class RepositorioGenerico<T> where T : class, new()
{
    private List<T> _elementos = new List<T>();

    // Método genérico simple
    public void Agregar(T elemento)
    {
        _elementos.Add(elemento);
    }

    // Método genérico con restricción adicional
    public TResult Transformar<TResult>(T elemento, Func<T, TResult> transformacion)
        where TResult : class
    {
        return transformacion(elemento);
    }

    // Método genérico con múltiples tipos
    public TResultado Combinar<TOtro, TResultado>(T primero, TOtro segundo, 
        Func<T, TOtro, TResultado> combinador)
        where TOtro : class
        where TResultado : class
    {
        return combinador(primero, segundo);
    }

    // Método genérico con restricción de interfaz
    public T ObtenerMayor<TComparable>(IEnumerable<T> elementos) 
        where T : IComparable<T>
    {
        return elementos.Max();
    }
}

// Diferentes tipos de restricciones genéricas
public static class MetodosGenericosAvanzados
{
    // Restricción: debe ser struct (tipo valor)
    public static bool EsDefault<T>(T valor) where T : struct
    {
        return valor.Equals(default(T));
    }

    // Restricción: debe tener constructor sin parámetros
    public static T CrearNuevo<T>() where T : new()
    {
        return new T();
    }

    // Restricción: debe heredar de una clase base
    public static void ProcesarEntidad<T>(T entidad) where T : EntidadBase
    {
        Console.WriteLine($"Procesando entidad ID: {entidad.Id}");
        entidad.ActualizarFechaModificacion();
    }

    // Múltiples restricciones
    public static T ProcesarSerializable<T>(T objeto) 
        where T : class, ISerializable, new()
    {
        objeto.Serializar();
        return new T();
    }

    // Método genérico con covarianza
    public static IEnumerable<TResult> MapearElementos<TSource, TResult>(
        IEnumerable<TSource> fuente, 
        Func<TSource, TResult> selector)
    {
        foreach (var elemento in fuente)
        {
            yield return selector(elemento);
        }
    }
}

#endregion

#region MÉTODOS ASÍNCRONOS (ASYNC/AWAIT)

public class ServicioAsincrono
{
    private static readonly HttpClient httpClient = new HttpClient();

    // Método async básico
    public async Task<string> ObtenerContenidoWebAsync(string url)
    {
        try
        {
            HttpResponseMessage response = await httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
        catch (HttpRequestException ex)
        {
            Console.WriteLine($"Error al obtener contenido: {ex.Message}");
            return string.Empty;
        }
    }

    // Método async con múltiples awaits
    public async Task<ResultadoProcesamiento> ProcesarDatosComplejoAsync(string[] urls)
    {
        var resultado = new ResultadoProcesamiento();
        var tareas = new List<Task<string>>();

        // Iniciar todas las tareas en paralelo
        foreach (string url in urls)
        {
            tareas.Add(ObtenerContenidoWebAsync(url));
        }

        try
        {
            // Esperar a que todas las tareas terminen
            string[] contenidos = await Task.WhenAll(tareas);
            
            resultado.ElementosProcesados = contenidos.Length;
            resultado.ContenidoTotal = string.Join("\n", contenidos);
            resultado.Exitoso = true;
        }
        catch (Exception ex)
        {
            resultado.Exitoso = false;
            resultado.Error = ex.Message;
        }

        return resultado;
    }

    // Método async con ConfigureAwait
    public async Task<bool> GuardarArchivoAsync(string ruta, string contenido)
    {
        try
        {
            // ConfigureAwait(false) para evitar deadlocks en aplicaciones UI
            await File.WriteAllTextAsync(ruta, contenido).ConfigureAwait(false);
            return true;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al guardar archivo: {ex.Message}");
            return false;
        }
    }

    // Método async con CancellationToken
    public async Task<string> OperacionConCancelacionAsync(
        string datos, 
        CancellationToken cancellationToken = default)
    {
        for (int i = 0; i < 10; i++)
        {
            // Verificar si se solicitó cancelación
            cancellationToken.ThrowIfCancellationRequested();

            // Simular trabajo asíncrono
            await Task.Delay(1000, cancellationToken);
            
            Console.WriteLine($"Procesando paso {i + 1}/10");
        }

        return $"Procesamiento completado para: {datos}";
    }

    // Método async con TimeOut
    public async Task<string> OperacionConTimeoutAsync(string url, int timeoutSegundos = 30)
    {
        using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(timeoutSegundos));
        
        try
        {
            return await ObtenerContenidoWebAsync(url).ConfigureAwait(false);
        }
        catch (OperationCanceledException)
        {
            return "Operación cancelada por timeout";
        }
    }

    // Método async genérico
    public async Task<TResult> ProcesarAsync<TInput, TResult>(
        TInput entrada, 
        Func<TInput, Task<TResult>> procesador)
    {
        Console.WriteLine($"Iniciando procesamiento de {typeof(TInput).Name}");
        
        var resultado = await procesador(entrada);
        
        Console.WriteLine($"Procesamiento completado, resultado: {typeof(TResult).Name}");
        return resultado;
    }
}

// Clase auxiliar para demostrar resultados
public class ResultadoProcesamiento
{
    public bool Exitoso { get; set; }
    public string Error { get; set; }
    public int ElementosProcesados { get; set; }
    public string ContenidoTotal { get; set; }
}

#endregion

#region EXTENSION METHODS

// Los Extension Methods deben estar en una clase estática
public static class ExtensionMethods
{
    // Extension method básico para string
    public static bool EsNuloOVacio(this string texto)
    {
        return string.IsNullOrEmpty(texto);
    }

    // Extension method para IEnumerable
    public static IEnumerable<T> ForEach<T>(this IEnumerable<T> fuente, Action<T> accion)
    {
        foreach (T elemento in fuente)
        {
            accion(elemento);
        }
        return fuente;
    }

    // Extension method con múltiples parámetros
    public static string Truncar(this string texto, int longitud, string sufijo = "...")
    {
        if (texto.EsNuloOVacio() || texto.Length <= longitud)
            return texto;

        return texto.Substring(0, longitud) + sufijo;
    }

    // Extension method genérico
    public static T CloneProfundo<T>(this T objeto) where T : ICloneable
    {
        return (T)objeto.Clone();
    }

    // Extension method para listas
    public static List<T> AgregarSi<T>(this List<T> lista, T elemento, bool condicion)
    {
        if (condicion)
            lista.Add(elemento);
        return lista;
    }

    // Extension method para diccionarios
    public static TValue ObtenerODefault<TKey, TValue>(
        this Dictionary<TKey, TValue> diccionario, 
        TKey clave, 
        TValue valorDefault = default)
    {
        return diccionario.TryGetValue(clave, out TValue valor) ? valor : valorDefault;
    }

    // Extension method complejo para validaciones
    public static ValidationResult Validar<T>(this T objeto) where T : class
    {
        var resultado = new ValidationResult();
        var propiedades = typeof(T).GetProperties();

        foreach (var propiedad in propiedades)
        {
            var valor = propiedad.GetValue(objeto);
            
            // Validar propiedades string no vacías
            if (propiedad.PropertyType == typeof(string) && valor != null)
            {
                if (string.IsNullOrWhiteSpace(valor.ToString()))
                {
                    resultado.Errores.Add($"La propiedad {propiedad.Name} no puede estar vacía");
                }
            }
        }

        resultado.EsValido = !resultado.Errores.Any();
        return resultado;
    }

    // Extension method asíncrono
    public static async Task<IEnumerable<TResult>> SeleccionarAsync<TSource, TResult>(
        this IEnumerable<TSource> fuente,
        Func<TSource, Task<TResult>> selector)
    {
        var tareas = fuente.Select(selector);
        return await Task.WhenAll(tareas);
    }

    // Extension method para HashSet (relacionado con la pregunta anterior)
    public static HashSet<T> AgregarRango<T>(this HashSet<T> hashSet, IEnumerable<T> elementos)
    {
        foreach (var elemento in elementos)
        {
            hashSet.Add(elemento);
        }
        return hashSet;
    }
}

// Clases auxiliares
public class ValidationResult
{
    public bool EsValido { get; set; }
    public List<string> Errores { get; set; } = new List<string>();
}

public abstract class EntidadBase
{
    public int Id { get; set; }
    public DateTime FechaCreacion { get; set; }
    public DateTime FechaModificacion { get; set; }

    public virtual void ActualizarFechaModificacion()
    {
        FechaModificacion = DateTime.Now;
    }
}

public interface ISerializable
{
    void Serializar();
}

public class Usuario : EntidadBase, ISerializable
{
    public string Nombre { get; set; }
    public string Email { get; set; }

    public void Serializar()
    {
        Console.WriteLine($"Serializando usuario: {Nombre}");
    }
}

#endregion

#region PROGRAMA PRINCIPAL PARA DEMOSTRAR USO

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("=== DEMOSTRACIÓN DE MÉTODOS AVANZADOS ===\n");

        // 1. MÉTODOS GENÉRICOS
        Console.WriteLine("1. MÉTODOS GENÉRICOS:");
        
        var repositorio = new RepositorioGenerico<Usuario>();
        var usuario = new Usuario { Id = 1, Nombre = "Juan", Email = "juan@test.com" };
        repositorio.Agregar(usuario);

        // Usar método genérico con transformación
        string info = repositorio.Transformar(usuario, u => $"{u.Nombre} ({u.Email})");
        Console.WriteLine($"Usuario transformado: {info}");

        // Método genérico estático
        bool esDefault = MetodosGenericosAvanzados.EsDefault(0);
        Console.WriteLine($"¿Es default? {esDefault}");

        // 2. EXTENSION METHODS
        Console.WriteLine("\n2. EXTENSION METHODS:");
        
        string texto = "Este es un texto muy largo que necesita ser truncado";
        string textoTruncado = texto.Truncar(20);
        Console.WriteLine($"Texto truncado: {textoTruncado}");

        var numeros = new List<int> { 1, 2, 3, 4, 5 };
        numeros.ForEach(n => Console.Write($"{n * 2} "));
        
        var hashSet = new HashSet<string>();
        hashSet.AgregarRango(new[] { "a", "b", "c" });
        Console.WriteLine($"\nHashSet: {string.Join(", ", hashSet)}");

        // 3. MÉTODOS ASÍNCRONOS
        Console.WriteLine("\n3. MÉTODOS ASÍNCRONOS:");
        
        var servicio = new ServicioAsincrono();
        
        try
        {
            // Simular operación asíncrona con timeout
            string resultado = await servicio.OperacionConTimeoutAsync("https://httpbin.org/delay/2", 5);
            Console.WriteLine($"Resultado async: {resultado.Truncar(50)}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error en operación async: {ex.Message}");
        }

        // Operación con cancelación
        using var cts = new CancellationTokenSource();
        cts.CancelAfter(3000); // Cancelar después de 3 segundos

        try
        {
            await servicio.OperacionConCancelacionAsync("datos de prueba", cts.Token);
        }
        catch (OperationCanceledException)
        {
            Console.WriteLine("Operación cancelada por el usuario");
        }

        Console.WriteLine("\n¡Demostración completada!");
    }
}

#endregion
```



## Sesión 5 Arreglos en C#

En esta sesión, los estudiantes aprenderán a declarar, inicializar, modificar y recorrer **arreglos (arrays)** en C#. Se explorará cómo los arreglos permiten almacenar múltiples valores del mismo tipo en una estructura ordenada y cómo acceder a sus elementos a través de índices. Además, se introducirán métodos útiles de la clase `Array` como `Sort`, `Reverse`, `IndexOf` y `Resize`, que permiten manipular y trabajar eficientemente con los datos almacenados.

### Objetivos de la sesión

- Comprender qué es un **arreglo** y su utilidad en el almacenamiento de datos homogéneos.
- Aprender a **declarar e inicializar** arreglos en C# usando distintas sintaxis.
- Utilizar **índices** para acceder y modificar valores dentro de un array.
- Aplicar estructuras de control (`for`, `foreach`) para recorrer arreglos.
- Emplear métodos de la clase `Array` para realizar operaciones comunes sobre colecciones de datos.

### Resultados esperados:

Al finalizar esta sesión, el estudiante será capaz de:

✅ Declarar arreglos unidimensionales y asignar valores manualmente o mediante inicialización directa.

✅ Acceder y modificar elementos individuales de un arreglo mediante su índice.

✅ Usar estructuras de control `for` y `foreach` para recorrer los elementos de un arreglo.

✅ Aplicar métodos como `Sort()`, `Reverse()`, `IndexOf()` y `Resize()` para ordenar, buscar y redimensionar arreglos.

✅ Comprender la importancia de los arreglos en la organización y procesamiento de datos en aplicaciones reales.

### 2.18. **Arreglos (Arrays) en C#**

En **C#**, un **array** (o arreglo) es una estructura de datos que permite almacenar múltiples valores del mismo tipo en una sola variable. Se accede a los elementos mediante índices numéricos, comenzando desde `0`.

**Declaración y Creación de un Array**

**Forma 1: Declaración e Inicialización Simultánea**

```c#
int[] numeros = { 10, 20, 30, 40, 50 };
```

📝 **Explicación:**

- Se declara un array `numeros` de tipo `int` y se inicializa con valores `{10, 20, 30, 40, 50}`.

------

**Declaración con Tamaño Fijo e Inicialización Posterior**

```c#
int[] edades = new int[3]; // Se define un array de 3 elementos
edades[0] = 25;
edades[1] = 30;
edades[2] = 35;
```

📝 **Explicación:**

- Se crea un array `edades` con **3 posiciones**.
- Se asignan valores usando **índices** (`0`, `1`, `2`).

------

**Declaración con `new` y Elementos**

```c#
string[] nombres = new string[] { "Ana", "Luis", "Pedro" };
```

📝 **Explicación:**

- Similar a la **Forma 1**, pero se usa `new string[]`.

------

**Acceder a los Elementos del Array**

Para acceder a un elemento, se usa su índice:

```c#
Console.WriteLine(numeros[0]); // Imprime 10
Console.WriteLine(nombres[1]); // Imprime "Luis"
```

------

#### 2.18.1. **Recorrer un Array**

Para recorrer los elementos, se usan estructuras de control como **`for`** o **`foreach`**.

📝**Usando `for`**

```c#
for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine(numeros[i]);
}
```

📌 **Explicación:**

- `numeros.Length` devuelve la cantidad de elementos en el array.

------

📝**Usando `foreach` (Recomendado para solo lectura)**

```c#
foreach (int num in numeros)
{
    Console.WriteLine(num);
}
```

📌 **Explicación:**

- `foreach` simplifica la iteración al acceder directamente a los valores.

------

#### **2.18.2.  Modificar el valor de un elemento en el Array**

```c#
numeros[2] = 100; // Cambia el valor en la posición 2
Console.WriteLine(numeros[2]); // Imprime 100
```

------

### **2.19. Métodos Útiles para Arrays**

C# proporciona métodos útiles en la clase `Array`:

| Método                                 | Descripción                         |
| -------------------------------------- | ----------------------------------- |
| `Array.Sort(array)`                    | Ordena el array en orden ascendente |
| `Array.Reverse(array)`                 | Invierte los elementos del array    |
| `Array.IndexOf(array, valor)`          | Retorna la posición del valor       |
| `Array.Resize(ref array, nuevoTamaño)` | Cambia el tamaño del array          |

**Ejemplo: Ordenar y Buscar en un Array**

```c#
int[] numeros = { 30, 10, 50, 20, 40 };
Array.Sort(numeros); // Ordena el array
Console.WriteLine(string.Join(", ", numeros)); // Imprime: 10, 20, 30, 40, 50

int posicion = Array.IndexOf(numeros, 30);
Console.WriteLine($"El 30 está en la posición {posicion}"); // Imprime 2
```

------

**Conclusión**

✅ Un array en C# es una estructura que **almacena elementos del mismo tipo**.
✅ Se accede mediante índices y **siempre inicia en `0`**.
✅ Puede ser **unidimensional, multidimensional o irregular**.
✅ La clase `Array` proporciona métodos útiles como `Sort()`, `Reverse()`, `IndexOf()`.

## Sesión 6: Colecciones dinámicas en C# — Listas, ArrayList y HashSet

**Descripción de la sesión:**

En esta sesión, los estudiantes aprenderán a manejar estructuras de datos dinámicas en C# utilizando las clases `List<T>`, `ArrayList` y `HashSet<T>`. Se explorarán sus características principales, métodos de manipulación, ventajas y diferencias, haciendo énfasis en la correcta selección de la colección según el contexto del problema. A través de ejercicios prácticos, se desarrollarán habilidades para almacenar, acceder, modificar y eliminar datos eficientemente.

**Objetivos de la sesión:**

- Comprender el uso de colecciones dinámicas en C# para almacenar y gestionar conjuntos de datos.
- Aprender a declarar, inicializar y manipular listas genéricas (`List<T>`), listas no genéricas (`ArrayList`) y conjuntos (`HashSet<T>`).
- Identificar las principales diferencias entre `List<T>`, `ArrayList` y `HashSet<T>` en cuanto a rendimiento, tipado, duplicados y orden.
- Utilizar métodos fundamentales como `Add`, `Remove`, `Insert`, `Sort`, `Clear`, `Contains`, `UnionWith`, entre otros.
- Aplicar estructuras de datos según el tipo de problema (por ejemplo, evitar duplicados con `HashSet` o almacenar elementos heterogéneos con `ArrayList`).

**Resultados esperados:**

Al finalizar esta sesión, el estudiante será capaz de:

✅ Crear y manipular listas genéricas (`List<T>`) para gestionar datos ordenados y tipados.

✅ Implementar operaciones como agregar, eliminar, buscar, ordenar e iterar elementos en una lista.

✅ Utilizar `ArrayList` para almacenar elementos de distintos tipos y comprender sus limitaciones frente a `List<T>`.

✅ Diferenciar los escenarios donde es preferible usar `ArrayList` o `List<T>`.

✅ Crear y utilizar `HashSet<T>` para almacenar elementos únicos y realizar operaciones de conjunto como unión, intersección y diferencia.

✅ Seleccionar la colección adecuada (`List`, `ArrayList` o `HashSet`) según el caso de uso.

✅ Resolver problemas reales utilizando estas colecciones en estructuras de clases personalizadas.



### 3.2. Listas

En C#, una **lista** (`List<T>`) es una estructura de datos que almacena una colección de elementos del mismo tipo de manera ordenada. A diferencia de los arreglos, su tamaño no es fijo, lo que permite añadir o eliminar elementos de forma dinámica según sea necesario.

📖Definición

```c#
public class List<T> : System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.Generic.IList<T>, System.Collections.Generic.IReadOnlyCollection<T>, System.Collections.Generic.IReadOnlyList<T>, System.Collections.IList
```

📖Constructores

| List()                | Inicializa una nueva instancia de la clase [List](https://learn.microsoft.com/es-es/dotnet/api/system.collections.generic.list-1?view=net-8.0) que está vacía y tiene la capacidad inicial predeterminada. |
| --------------------- | ------------------------------------------------------------ |
| **List(IEnumerable)** | Inicializa una nueva instancia de la clase [List](https://learn.microsoft.com/es-es/dotnet/api/system.collections.generic.list-1?view=net-8.0) que contiene elementos copiados de la colección especificada y tiene capacidad suficiente para acomodar el número de elementos copiados. |
| **List(Int32)**       | Inicializa una nueva instancia de la clase [List](https://learn.microsoft.com/es-es/dotnet/api/system.collections.generic.list-1?view=net-8.0) que está vacía y tiene la capacidad inicial especificada. |

Obtenido: https://learn.microsoft.com/es-es/dotnet/api/system.collections.generic.list-1?view=net-8.0#definition

#### 3.2.1. Crear listas en C#

```c#
List<T> lista = new List<T>();
```

También se puede inicializar una lista con elementos utilizando la siguiente sintaxis:

```c#
List<T> lista = new List<T>() { elemento1, elemento2, elemento3, ... };
```

**Sintaxis con `new`**

```c#
List<string> miLista = new List<string>();
miLista.Add("Manzana");
miLista.Add("Plátano");
miLista.Add("Naranja");
```

**Sintaxis de inicialización de colección**

```c#
List<int> miLista = new List<int> { 1, 2, 3, 4, 5 };
```

**Añadir elementos en una lista**

```c#
List<int> numeros = new List<int>();

// Añadir elementos a la lista
numeros.Add(1);
numeros.Add(2);
numeros.Add(3);
```

**Eliminar elementos**

📍Remove() : Elimina la primera aparición de un elemento en la lista.

```c#
List<string> lista = new List<string> {"manzana", "naranja", "pera", "uva"};
lista.Remove("pera");
```

📍RemoveAt() : Elimina un elemento de la lista en un índice específico.

```c#
List<string> lista = new List<string> {"manzana", "naranja", "pera", "uva"};
lista.RemoveAt(2);
```

📍RemoveRange() : Elimina una sección de la lista que incluye un rango de elementos, comenzando en un índice específico.

```c#
List<string> lista = new List<string> {"manzana", "naranja", "pera", "uva"};
lista.RemoveRange(1, 2);
```

📍Clear() : Elimina todos los elementos de la lista.

```c#
List<string> lista = new List<string> {"manzana", "naranja", "pera", "uva"};
lista.Clear();
```

📍RemoveAll(): Elimina todos los elementos de la lista que cumplen con un predicado específico.

```c#
List<int> lista = new List<int> {1, 2, 3, 4, 5};
lista.RemoveAll(n => n % 2 == 0);
```



#### 3.2.2. Propiedades

| Capacity     | Obtiene o establece el número total de elementos que la estructura de datos interna puede contener sin cambiar el tamaño. |
| ------------ | ------------------------------------------------------------ |
| Count        | Obtiene el número de elementos contenidos en el [List](https://learn.microsoft.com/es-es/dotnet/api/system.collections.generic.list-1?view=net-8.0). |
| Item[Int32\] | Obtiene o establece el elemento en el índice especificado.   |

Obtenido: https://learn.microsoft.com/es-es/dotnet/api/system.collections.generic.list-1?view=net-8.0#definition

#### 3.2.3. Métodos

| Add(T)                                   | Agrega un objeto al final del [List](https://learn.microsoft.com/es-es/dotnet/api/system.collections.generic.list-1?view=net-8.0). |
| ---------------------------------------- | ------------------------------------------------------------ |
| AddRange(IEnumerable)                    | Agrega los elementos de la colección especificada al final del [List](https://learn.microsoft.com/es-es/dotnet/api/system.collections.generic.list-1?view=net-8.0). |
| AsReadOnly()                             | Devuelve un contenedor de [ReadOnlyCollection](https://learn.microsoft.com/es-es/dotnet/api/system.collections.objectmodel.readonlycollection-1?view=net-8.0) de solo lectura para la colección actual. |
| BinarySearch(Int32, Int32, T, IComparer) | Busca un intervalo de elementos en el [List](https://learn.microsoft.com/es-es/dotnet/api/system.collections.generic.list-1?view=net-8.0) ordenado para un elemento mediante el comparador especificado y devuelve el índice de base cero del elemento. |
| BinarySearch(T)                          | Busca en toda la [List](https://learn.microsoft.com/es-es/dotnet/api/system.collections.generic.list-1?view=net-8.0) ordenada un elemento mediante el comparador predeterminado y devuelve el índice de base cero del elemento. |
| BinarySearch(T, IComparer)               | Busca en todo el [List](https://learn.microsoft.com/es-es/dotnet/api/system.collections.generic.list-1?view=net-8.0) ordenado de un elemento mediante el comparador especificado y devuelve el índice de base cero del elemento. |
| Clear()                                  | Quita todos los elementos de la [List](https://learn.microsoft.com/es-es/dotnet/api/system.collections.generic.list-1?view=net-8.0). |
| Contains(T)                              | Determina si un elemento está en el [List](https://learn.microsoft.com/es-es/dotnet/api/system.collections.generic.list-1?view=net-8.0). |
| ConvertAll(Converter)                    | Convierte los elementos de la [List](https://learn.microsoft.com/es-es/dotnet/api/system.collections.generic.list-1?view=net-8.0) actual en otro tipo y devuelve una lista que contiene los elementos convertidos. |
| CopyTo(Int32, T[\])                      | Copia un intervalo de elementos de la [List](https://learn.microsoft.com/es-es/dotnet/api/system.collections.generic.list-1?view=net-8.0) a una matriz unidimensional compatible, empezando por el índice especificado de la matriz de destino. |
| CopyTo(T[\])                             | Copia toda la [List](https://learn.microsoft.com/es-es/dotnet/api/system.collections.generic.list-1?view=net-8.0) en una matriz unidimensional compatible, comenzando al principio de la matriz de destino. |
| CopyTo(T[\], Int32)                      | Copia toda la [List](https://learn.microsoft.com/es-es/dotnet/api/system.collections.generic.list-1?view=net-8.0) en una matriz unidimensional compatible, empezando por el índice especificado de la matriz de destino. |
| EnsureCapacity(Int32)                    | Garantiza que la capacidad de esta lista sea al menos la `capacity`especificada. Si la capacidad actual es menor que `capacity`, se aumenta a al menos el `capacity`especificado. |
| Equals(Object)                           | Determina si el objeto especificado es igual al objeto actual.(Heredado de [Object](https://learn.microsoft.com/es-es/dotnet/api/system.object?view=net-8.0)) |
| Exists(Predicate)                        | Determina si el [List](https://learn.microsoft.com/es-es/dotnet/api/system.collections.generic.list-1?view=net-8.0) contiene elementos que coinciden con las condiciones definidas por el predicado especificado. |
| Find(Predicate)                          | Busca un elemento que coincida con las condiciones definidas por el predicado especificado y devuelve la primera aparición dentro de toda la [List](https://learn.microsoft.com/es-es/dotnet/api/system.collections.generic.list-1?view=net-8.0). |
| FindAll(Predicate)                       | Recupera todos los elementos que coinciden con las condiciones definidas por el predicado especificado. |
| FindIndex(Int32, Int32, Predicate)       | Busca un elemento que coincida con las condiciones definidas por el predicado especificado y devuelve el índice de base cero de la primera aparición dentro del intervalo de elementos del [List](https://learn.microsoft.com/es-es/dotnet/api/system.collections.generic.list-1?view=net-8.0) que comienza en el índice especificado y contiene el número especificado de elementos. |
| FindIndex(Int32, Predicate)              | Busca un elemento que coincida con las condiciones definidas por el predicado especificado y devuelve el índice de base cero de la primera aparición dentro del intervalo de elementos del [List](https://learn.microsoft.com/es-es/dotnet/api/system.collections.generic.list-1?view=net-8.0) que se extiende del índice especificado al último elemento. |
| FindIndex(Predicate)                     | Busca un elemento que coincida con las condiciones definidas por el predicado especificado y devuelve el índice de base cero de la primera aparición dentro de toda la [List](https://learn.microsoft.com/es-es/dotnet/api/system.collections.generic.list-1?view=net-8.0). |
| FindLast(Predicate)                      | Busca un elemento que coincida con las condiciones definidas por el predicado especificado y devuelve la última aparición dentro de toda la [List](https://learn.microsoft.com/es-es/dotnet/api/system.collections.generic.list-1?view=net-8.0). |
| FindLastIndex(Int32, Int32, Predicate)   | Busca un elemento que coincida con las condiciones definidas por el predicado especificado y devuelve el índice de base cero de la última aparición dentro del intervalo de elementos de la [List](https://learn.microsoft.com/es-es/dotnet/api/system.collections.generic.list-1?view=net-8.0) que contiene el número especificado de elementos y termina en el índice especificado. |
| FindLastIndex(Int32, Predicate)          | Busca un elemento que coincida con las condiciones definidas por el predicado especificado y devuelve el índice de base cero de la última aparición dentro del intervalo de elementos del [List](https://learn.microsoft.com/es-es/dotnet/api/system.collections.generic.list-1?view=net-8.0) que se extiende desde el primer elemento al índice especificado. |
| FindLastIndex(Predicate)                 | Busca un elemento que coincida con las condiciones definidas por el predicado especificado y devuelve el índice de base cero de la última aparición en toda la [List](https://learn.microsoft.com/es-es/dotnet/api/system.collections.generic.list-1?view=net-8.0). |
| ForEach(Action)                          | Realiza la acción especificada en cada elemento del [List](https://learn.microsoft.com/es-es/dotnet/api/system.collections.generic.list-1?view=net-8.0). |
| GetEnumerator()                          | Devuelve un enumerador que recorre en iteración el [List](https://learn.microsoft.com/es-es/dotnet/api/system.collections.generic.list-1?view=net-8.0). |
| GetHashCode()                            | Actúa como función hash predeterminada.(Heredado de [Object](https://learn.microsoft.com/es-es/dotnet/api/system.object?view=net-8.0)) |
| GetRange(Int32, Int32)                   | Crea una copia superficial de un intervalo de elementos en el [List](https://learn.microsoft.com/es-es/dotnet/api/system.collections.generic.list-1?view=net-8.0)de origen . |
| GetType()                                | Obtiene el [Type](https://learn.microsoft.com/es-es/dotnet/api/system.type?view=net-8.0) de la instancia actual.(Heredado de [Object](https://learn.microsoft.com/es-es/dotnet/api/system.object?view=net-8.0)) |
| IndexOf(T)                               | Busca el objeto especificado y devuelve el índice de base cero de la primera aparición dentro de toda la [List](https://learn.microsoft.com/es-es/dotnet/api/system.collections.generic.list-1?view=net-8.0). |
| IndexOf(T, Int32)                        | Busca el objeto especificado y devuelve el índice de base cero de la primera aparición dentro del intervalo de elementos del [List](https://learn.microsoft.com/es-es/dotnet/api/system.collections.generic.list-1?view=net-8.0) que se extiende desde el índice especificado hasta el último elemento. |
| IndexOf(T, Int32, Int32)                 | Busca el objeto especificado y devuelve el índice de base cero de la primera aparición dentro del intervalo de elementos del [List](https://learn.microsoft.com/es-es/dotnet/api/system.collections.generic.list-1?view=net-8.0) que comienza en el índice especificado y contiene el número especificado de elementos. |
| Insert(Int32, T)                         | Inserta un elemento en el [List](https://learn.microsoft.com/es-es/dotnet/api/system.collections.generic.list-1?view=net-8.0) en el índice especificado. |
| InsertRange(Int32, IEnumerable)          | Inserta los elementos de una colección en el [List](https://learn.microsoft.com/es-es/dotnet/api/system.collections.generic.list-1?view=net-8.0) en el índice especificado. |
| LastIndexOf(T)                           | Busca el objeto especificado y devuelve el índice de base cero de la última aparición en toda la [List](https://learn.microsoft.com/es-es/dotnet/api/system.collections.generic.list-1?view=net-8.0). |
| LastIndexOf(T, Int32)                    | Busca el objeto especificado y devuelve el índice de base cero de la última aparición dentro del intervalo de elementos del [List](https://learn.microsoft.com/es-es/dotnet/api/system.collections.generic.list-1?view=net-8.0) que se extiende desde el primer elemento al índice especificado. |
| LastIndexOf(T, Int32, Int32)             | Busca el objeto especificado y devuelve el índice de base cero de la última aparición dentro del intervalo de elementos del [List](https://learn.microsoft.com/es-es/dotnet/api/system.collections.generic.list-1?view=net-8.0) que contiene el número especificado de elementos y termina en el índice especificado. |
| MemberwiseClone()                        | Crea una copia superficial del [Object](https://learn.microsoft.com/es-es/dotnet/api/system.object?view=net-8.0)actual.(Heredado de [Object](https://learn.microsoft.com/es-es/dotnet/api/system.object?view=net-8.0)) |
| Remove(T)                                | Quita la primera aparición de un objeto específico de la [List](https://learn.microsoft.com/es-es/dotnet/api/system.collections.generic.list-1?view=net-8.0). |
| RemoveAll(Predicate)                     | Quita todos los elementos que coinciden con las condiciones definidas por el predicado especificado. |
| RemoveAt(Int32)                          | Quita el elemento en el índice especificado del [List](https://learn.microsoft.com/es-es/dotnet/api/system.collections.generic.list-1?view=net-8.0). |
| RemoveRange(Int32, Int32)                | Quita un intervalo de elementos de la [List](https://learn.microsoft.com/es-es/dotnet/api/system.collections.generic.list-1?view=net-8.0). |
| Reverse()                                | Invierte el orden de los elementos en toda la [List](https://learn.microsoft.com/es-es/dotnet/api/system.collections.generic.list-1?view=net-8.0). |
| Reverse(Int32, Int32)                    | Invierte el orden de los elementos del intervalo especificado. |
| Slice(Int32, Int32)                      | Crea una copia superficial de un intervalo de elementos en el [List](https://learn.microsoft.com/es-es/dotnet/api/system.collections.generic.list-1?view=net-8.0)de origen . |
| Sort()                                   | Ordena los elementos de toda la [List](https://learn.microsoft.com/es-es/dotnet/api/system.collections.generic.list-1?view=net-8.0) mediante el comparador predeterminado. |
| Sort(Comparison)                         | Ordena los elementos de toda la [List](https://learn.microsoft.com/es-es/dotnet/api/system.collections.generic.list-1?view=net-8.0) mediante el [Comparison](https://learn.microsoft.com/es-es/dotnet/api/system.comparison-1?view=net-8.0)especificado. |
| Sort(IComparer)                          | Ordena los elementos de toda la [List](https://learn.microsoft.com/es-es/dotnet/api/system.collections.generic.list-1?view=net-8.0) mediante el comparador especificado. |
| Sort(Int32, Int32, IComparer)            | Ordena los elementos de un intervalo de elementos de [List](https://learn.microsoft.com/es-es/dotnet/api/system.collections.generic.list-1?view=net-8.0) utilizando el comparador especificado. |
| ToArray()                                | Copia los elementos del [List](https://learn.microsoft.com/es-es/dotnet/api/system.collections.generic.list-1?view=net-8.0) en una nueva matriz. |
| ToString()                               | Devuelve una cadena que representa el objeto actual.(Heredado de [Object](https://learn.microsoft.com/es-es/dotnet/api/system.object?view=net-8.0)) |
| TrimExcess()                             | Establece la capacidad en el número real de elementos de la [List](https://learn.microsoft.com/es-es/dotnet/api/system.collections.generic.list-1?view=net-8.0), si ese número es menor que un valor de umbral. |
| TrueForAll(Predicate)                    | Determina si cada elemento de la [List](https://learn.microsoft.com/es-es/dotnet/api/system.collections.generic.list-1?view=net-8.0) coincide con las condiciones definidas por el predicado especificado. |

Obtenido: https://learn.microsoft.com/es-es/dotnet/api/system.collections.generic.list-1?view=net-8.0#definition

```c#
using System;
using System.Collections.Generic;

class Programa
{
    static void Main()
    {
        List<string> frutas = new List<string>();

        frutas.Add("Manzana");
        frutas.Add("Banano");
        frutas.Add("Pera");

        foreach (string fruta in frutas)
        {
            Console.WriteLine(fruta);
        }
    }
}
```

```c#
List<int> numeros = new List<int>() { 10, 5, 8, 3, 1 };

// Ordenar
numeros.Sort();

// Buscar si contiene el número 5
if (numeros.Contains(5))
{
    Console.WriteLine("La lista contiene el número 5.");
}

// Eliminar el número 3
numeros.Remove(3);

// Mostrar elementos
foreach (int num in numeros)
{
    Console.WriteLine(num);
}
```

```c#
using System;
using System.Collections.Generic;

class Programa
{
    static void Main()
    {
        // Crear lista
        List<string> estudiantes = new List<string>();

        // Agregar elementos con Add()
        estudiantes.Add("Carlos");
        estudiantes.Add("María");
        estudiantes.Add("Lucía");
        estudiantes.Add("Pedro");

        Console.WriteLine("Lista original:");
        MostrarLista(estudiantes);

        // Insertar elemento con Insert()
        estudiantes.Insert(2, "Juan"); // Inserta en la posición 2

        Console.WriteLine("\nDespués de insertar a Juan en la posición 2:");
        MostrarLista(estudiantes);

        // Verificar si contiene un elemento con Contains()
        Console.WriteLine("\n¿La lista contiene a Pedro?");
        Console.WriteLine(estudiantes.Contains("Pedro")); // true

        // Obtener índice de un elemento con IndexOf()
        Console.WriteLine("\nÍndice de Lucía:");
        Console.WriteLine(estudiantes.IndexOf("Lucía")); // puede variar si insertamos algo antes

        // Eliminar un elemento por valor con Remove()
        estudiantes.Remove("Carlos");

        Console.WriteLine("\nDespués de eliminar a Carlos:");
        MostrarLista(estudiantes);

        // Eliminar un elemento por índice con RemoveAt()
        estudiantes.RemoveAt(1); // elimina al que está en la posición 1

        Console.WriteLine("\nDespués de eliminar el elemento en la posición 1:");
        MostrarLista(estudiantes);

        // Ordenar la lista con Sort()
        estudiantes.Sort();

        Console.WriteLine("\nLista ordenada:");
        MostrarLista(estudiantes);

        // Mostrar cantidad con Count
        Console.WriteLine($"\nCantidad de estudiantes: {estudiantes.Count}");

        // Vaciar lista con Clear()
        estudiantes.Clear();

        Console.WriteLine("\nDespués de limpiar la lista:");
        Console.WriteLine($"Cantidad de elementos: {estudiantes.Count}");
    }

    static void MostrarLista(List<string> lista)
    {
        foreach (string item in lista)
        {
            Console.WriteLine($"- {item}");
        }
    }
}
```

**Métodos usados en el ejercicio**

| Método       | ¿Qué hizo?                                     |
| ------------ | ---------------------------------------------- |
| `Add()`      | Agregó elementos a la lista                    |
| `Insert()`   | Insertó un elemento en una posición específica |
| `Contains()` | Verificó si un elemento existe                 |
| `IndexOf()`  | Obtuvo el índice de un elemento                |
| `Remove()`   | Eliminó un elemento por su valor               |
| `RemoveAt()` | Eliminó un elemento por su índice              |
| `Sort()`     | Ordenó la lista alfabéticamente                |
| `Count`      | Mostró la cantidad total de elementos          |
| `Clear()`    | Vació la lista                                 |

```c#
using System;
using System.Collections.Generic;

class Estudiante
{
    public string Nombre { get; set; }
    public int Edad { get; set; }

    public Estudiante(string nombre, int edad)
    {
        Nombre = nombre;
        Edad = edad;
    }

    public override string ToString()
    {
        return $"{Nombre} - {Edad} años";
    }
}

class Programa
{
    static void Main()
    {
        List<Estudiante> estudiantes = new List<Estudiante>();

        // Add()
        estudiantes.Add(new Estudiante("Lucía", 20));
        estudiantes.Add(new Estudiante("Carlos", 22));
        estudiantes.Add(new Estudiante("María", 19));
        estudiantes.Add(new Estudiante("Pedro", 21));

        Console.WriteLine("🎓 Lista de estudiantes:");
        MostrarLista(estudiantes);

        // Insert()
        estudiantes.Insert(2, new Estudiante("Juan", 23));
        Console.WriteLine("\n🎯 Después de insertar a Juan en la posición 2:");
        MostrarLista(estudiantes);

        // Contains() (usaremos referencia exacta para que funcione)
        Estudiante lucia = estudiantes[0];
        Console.WriteLine("\n🔍 ¿La lista contiene a Lucía?");
        Console.WriteLine(estudiantes.Contains(lucia)); // true

        // IndexOf()
        int indiceMaria = estudiantes.IndexOf(estudiantes.Find(e => e.Nombre == "María"));
        Console.WriteLine($"\n📌 Índice de María: {indiceMaria}");

        // Remove() por referencia
        estudiantes.Remove(lucia);
        Console.WriteLine("\n❌ Después de eliminar a Lucía:");
        MostrarLista(estudiantes);

        // RemoveAt()
        estudiantes.RemoveAt(1);
        Console.WriteLine("\n🚫 Después de eliminar el estudiante en la posición 1:");
        MostrarLista(estudiantes);

        // Sort() por Edad (requiere un comparador)
        estudiantes.Sort((a, b) => a.Edad.CompareTo(b.Edad));
        Console.WriteLine("\n📊 Lista ordenada por edad:");
        MostrarLista(estudiantes);

        // Count
        Console.WriteLine($"\n📋 Total de estudiantes: {estudiantes.Count}");

        // Clear()
        estudiantes.Clear();
        Console.WriteLine("\n🧹 Después de limpiar la lista:");
        Console.WriteLine($"Elementos restantes: {estudiantes.Count}");
    }

    static void MostrarLista(List<Estudiante> lista)
    {
        foreach (Estudiante est in lista)
        {
            Console.WriteLine($"- {est}");
        }
    }
}
```



### 3.3. ArrayList

Un **`ArrayList`** en C# es una estructura de datos perteneciente al espacio de nombres `System.Collections`. Se trata de una colección que puede contener elementos de diferentes tipos y ajustar su tamaño dinámicamente, sin necesidad de definir una capacidad fija.

------

**Características de `ArrayList`**

- Permite almacenar elementos de **cualquier tipo de datos** (`object`).
- **No es genérico**, a diferencia de `List<T>`, lo que significa que puede almacenar diferentes tipos de datos en la misma colección.
- Puede **cambiar de tamaño dinámicamente**, agregando o eliminando elementos sin necesidad de definir un tamaño fijo.
- Se recomienda **usar `List<T>` en lugar de `ArrayList`**, ya que `List<T>` ofrece mejor rendimiento y seguridad de tipo.

**Constructores**

| ArrayList()            | Inicializa una nueva instancia de la clase [ArrayList](https://learn.microsoft.com/es-es/dotnet/api/system.collections.arraylist?view=net-8.0) que está vacía y tiene la capacidad inicial predeterminada. |
| ---------------------- | ------------------------------------------------------------ |
| ArrayList(ICollection) | Inicializa una nueva instancia de la clase [ArrayList](https://learn.microsoft.com/es-es/dotnet/api/system.collections.arraylist?view=net-8.0) que contiene elementos copiados de la colección especificada y que tiene la misma capacidad inicial que el número de elementos copiados. |
| ArrayList(Int32)       | Inicializa una nueva instancia de la clase [ArrayList](https://learn.microsoft.com/es-es/dotnet/api/system.collections.arraylist?view=net-8.0) que está vacía y tiene la capacidad inicial especificada. |

#### **3.3.1. Propiedades**

| Capacity       | Obtiene o establece el número de elementos que puede contener [ArrayList](https://learn.microsoft.com/es-es/dotnet/api/system.collections.arraylist?view=net-8.0). |
| -------------- | ------------------------------------------------------------ |
| Count          | Obtiene el número de elementos contenido realmente en [ArrayList](https://learn.microsoft.com/es-es/dotnet/api/system.collections.arraylist?view=net-8.0). |
| IsFixedSize    | Obtiene un valor que indica si la interfaz [ArrayList](https://learn.microsoft.com/es-es/dotnet/api/system.collections.arraylist?view=net-8.0) tiene un tamaño fijo. |
| IsReadOnly     | Obtiene un valor que indica si [ArrayList](https://learn.microsoft.com/es-es/dotnet/api/system.collections.arraylist?view=net-8.0) es de solo lectura. |
| IsSynchronized | Obtiene un valor que indica si el acceso a la interfaz [ArrayList](https://learn.microsoft.com/es-es/dotnet/api/system.collections.arraylist?view=net-8.0) está sincronizado (es seguro para subprocesos). |
| Item[Int32\]   | Obtiene o establece el elemento en el índice especificado.   |
| SyncRoot       | Obtiene un objeto que se puede usar para sincronizar el acceso a [ArrayList](https://learn.microsoft.com/es-es/dotnet/api/system.collections.arraylist?view=net-8.0). |

#### **3.3.2. Principales Métodos de `ArrayList`**

| Método                  | Descripción                                                  |
| ----------------------- | ------------------------------------------------------------ |
| `Add(object)`           | Agrega un elemento al final.                                 |
| `Insert(index, object)` | Inserta un elemento en una posición específica.              |
| `Remove(object)`        | Elimina la primera ocurrencia del elemento.                  |
| `RemoveAt(index)`       | Elimina el elemento en el índice especificado.               |
| `Clear()`               | Elimina todos los elementos de la lista.                     |
| `Contains(object)`      | Verifica si un elemento existe en la lista.                  |
| `IndexOf(object)`       | Devuelve el índice de la primera aparición del elemento.     |
| `Sort()`                | Ordena los elementos si son comparables.                     |
| `Count`                 | Propiedad que devuelve la cantidad de elementos en la lista. |

#### 3.3.3. **Diferencia entre `ArrayList` y `List<T>`**

| Característica    | `ArrayList`                                  | `List<T>`                                  |
| ----------------- | -------------------------------------------- | ------------------------------------------ |
| Seguridad de tipo | No (puede contener diferentes tipos)         | Sí (almacena un solo tipo de datos)        |
| Rendimiento       | Más lento debido a la conversión de tipos    | Más rápido gracias a la seguridad de tipos |
| Uso recomendado   | Solo si necesitas almacenar tipos diferentes | Siempre que sepas qué tipo de datos usar   |

```c#
using System;
using System.Collections;

class Programa
{
    static void Main()
    {
        // Crear un ArrayList
        ArrayList lista = new ArrayList();

        // Add() - Agregar elementos
        lista.Add("Carlos");
        lista.Add("Lucía");
        lista.Add("Pedro");
        lista.Add(2024); // Se pueden mezclar tipos (¡no recomendado!)

        Console.WriteLine("📋 Lista original:");
        MostrarLista(lista);

        // Insert() - Insertar en una posición específica
        lista.Insert(1, "María");
        Console.WriteLine("\n🎯 Después de insertar a María en la posición 1:");
        MostrarLista(lista);

        // Contains() - Verificar si existe un elemento
        Console.WriteLine("\n🔍 ¿La lista contiene a Pedro?");
        Console.WriteLine(lista.Contains("Pedro")); // true

        // IndexOf() - Buscar índice de un elemento
        int indice = lista.IndexOf("Lucía");
        Console.WriteLine($"\n📌 Índice de Lucía: {indice}");

        // Remove() - Eliminar un elemento
        lista.Remove("Carlos");
        Console.WriteLine("\n❌ Después de eliminar a Carlos:");
        MostrarLista(lista);

        // RemoveAt() - Eliminar por índice
        lista.RemoveAt(0);
        Console.WriteLine("\n🚫 Después de eliminar el elemento en la posición 0:");
        MostrarLista(lista);

        // Sort() - Ordenar (solo si todos los elementos son del mismo tipo y comparables)
        lista.Clear();
        lista.Add("Zulema");
        lista.Add("Andrés");
        lista.Add("Beatriz");
        lista.Sort(); // funciona con strings
        Console.WriteLine("\n📊 Lista ordenada alfabéticamente:");
        MostrarLista(lista);

        // Count - Cantidad de elementos
        Console.WriteLine($"\n📌 Cantidad de elementos: {lista.Count}");

        // Clear() - Limpiar la lista
        lista.Clear();
        Console.WriteLine("\n🧹 Después de limpiar la lista:");
        Console.WriteLine($"Cantidad de elementos: {lista.Count}");
    }

    static void MostrarLista(ArrayList lista)
    {
        foreach (var item in lista)
        {
            Console.WriteLine($"- {item}");
        }
    }
}
```

**Métodos usados**

| Método / Propiedad | Descripción                                 |
| ------------------ | ------------------------------------------- |
| `Add()`            | Agrega un elemento al final                 |
| `Insert()`         | Inserta un elemento en cierta posición      |
| `Contains()`       | Verifica si contiene cierto valor           |
| `IndexOf()`        | Retorna el índice de un valor               |
| `Remove()`         | Elimina un valor                            |
| `RemoveAt()`       | Elimina por posición                        |
| `Sort()`           | Ordena los elementos (requiere uniformidad) |
| `Count`            | Retorna la cantidad de elementos            |
| `Clear()`          | Vacía la lista                              |

**Ejemplo: `ArrayList` con objetos personalizados (`Estudiante`)**

```c#
using System;
using System.Collections;

class Estudiante
{
    public string Nombre { get; set; }
    public int Edad { get; set; }

    public Estudiante(string nombre, int edad)
    {
        Nombre = nombre;
        Edad = edad;
    }

    public override string ToString()
    {
        return $"{Nombre} - {Edad} años";
    }
}

class Programa
{
    static void Main()
    {
        // Crear un ArrayList de estudiantes
        ArrayList estudiantes = new ArrayList();

        estudiantes.Add(new Estudiante("Lucía", 20));
        estudiantes.Add(new Estudiante("Carlos", 22));
        estudiantes.Add(new Estudiante("María", 19));
        estudiantes.Add(new Estudiante("Pedro", 21));

        Console.WriteLine("📋 Lista original:");
        MostrarEstudiantes(estudiantes);

        // Insertar nuevo estudiante
        estudiantes.Insert(2, new Estudiante("Juan", 23));
        Console.WriteLine("\n🎯 Después de insertar a Juan en la posición 2:");
        MostrarEstudiantes(estudiantes);

        // Buscar estudiante (Contains usa referencia exacta)
        Estudiante maria = (Estudiante)estudiantes[3];
        Console.WriteLine("\n🔍 ¿La lista contiene a María?");
        Console.WriteLine(estudiantes.Contains(maria)); // true

        // Eliminar estudiante
        estudiantes.Remove(maria);
        Console.WriteLine("\n❌ Después de eliminar a María:");
        MostrarEstudiantes(estudiantes);

        // Ordenar por edad (usando IComparer personalizado)
        estudiantes.Sort(new ComparadorEdad());
        Console.WriteLine("\n📊 Lista ordenada por edad:");
        MostrarEstudiantes(estudiantes);

        // Vaciar la lista
        estudiantes.Clear();
        Console.WriteLine("\n🧹 Después de limpiar la lista:");
        Console.WriteLine($"Elementos restantes: {estudiantes.Count}");
    }

    // Método para imprimir estudiantes
    static void MostrarEstudiantes(ArrayList lista)
    {
        foreach (Estudiante est in lista)
        {
            Console.WriteLine($"- {est}");
        }
    }
}

// Comparador personalizado para ordenar por edad
class ComparadorEdad : IComparer
{
    public int Compare(object x, object y)
    {
        Estudiante est1 = (Estudiante)x;
        Estudiante est2 = (Estudiante)y;
        return est1.Edad.CompareTo(est2.Edad);
    }
}
```

### 3.4. **HashSet en C#**

El **`HashSet<T>`** es una colección en C# que pertenece al espacio de nombres `System.Collections.Generic`. Se caracteriza por almacenar elementos **únicos**, sin permitir duplicados, y por ofrecer una búsqueda y manipulación de datos de manera eficiente.

#### 3.4.1. Propiedades

| Comparer | Obtiene el objeto [IEqualityComparer](https://learn.microsoft.com/es-es/dotnet/api/system.collections.generic.iequalitycomparer-1?view=net-8.0) que se usa para determinar la igualdad de los valores del conjunto. |
| -------- | ------------------------------------------------------------ |
| Count    | Obtiene el número de elementos contenidos en un conjunto.    |

#### 3.4.2.**Principales Métodos de `HashSet<T>`**

| Método                      | Descripción                                                  |
| --------------------------- | ------------------------------------------------------------ |
| `Add(T item)`               | Agrega un elemento si no está en el conjunto.                |
| `Remove(T item)`            | Elimina un elemento del conjunto.                            |
| `Contains(T item)`          | Verifica si el elemento existe en el conjunto.               |
| `Clear()`                   | Elimina todos los elementos.                                 |
| `Count`                     | Devuelve el número de elementos en el conjunto.              |
| `UnionWith(HashSet<T>)`     | Une dos conjuntos, eliminando duplicados.                    |
| `IntersectWith(HashSet<T>)` | Mantiene solo los elementos que están en ambos conjuntos.    |
| `ExceptWith(HashSet<T>)`    | Elimina del conjunto los elementos que están en otro conjunto. |

📖**Diferencias entre `HashSet<T>` y `List<T>`**

| Característica               | `HashSet<T>`                                                 | `List<T>`                                             |
| ---------------------------- | ------------------------------------------------------------ | ----------------------------------------------------- |
| **Permite duplicados**       | ❌ No                                                         | ✅ Sí                                                  |
| **Orden de los elementos**   | ❌ No garantizado                                             | ✅ Sí, conserva el orden de inserción                  |
| **Rendimiento en búsquedas** | 🚀 Muy rápido (`O(1)`)                                        | 🐢 Más lento (`O(n)`)                                  |
| **Uso recomendado**          | Cuando se necesita evitar duplicados y mejorar la velocidad de búsqueda | Cuando se requiere mantener el orden de los elementos |

📖**Características principales de `HashSet<T>`**

- **No permite elementos duplicados**.
- **No garantiza un orden específico** de los elementos.
- **Optimizado para búsquedas rápidas**, ya que internamente usa una tabla hash.
- Admite operaciones de **conjunto matemático** como unión, intersección y diferencia.
- Es una alternativa eficiente a `List<T>` cuando se necesita **evitar duplicados y mejorar el rendimiento** en búsquedas.

```c#
HashSet<int> setA = new HashSet<int> { 1, 2, 3, 4, 5 };
HashSet<int> setB = new HashSet<int> { 4, 5, 6, 7, 8 };

// Unión de conjuntos
setA.UnionWith(setB);
Console.WriteLine("Unión: " + string.Join(", ", setA));

// Intersección de conjuntos
setA.IntersectWith(setB);
Console.WriteLine("Intersección: " + string.Join(", ", setA));

// Diferencia (eliminar elementos de setA que estén en setB)
setA.ExceptWith(setB);
Console.WriteLine("Diferencia: " + string.Join(", ", setA));

```

Ejemplo avanzado

## Características destacadas:

**1. HashSet con objetos personalizados:**

- Override de `Equals()` y `GetHashCode()` para comparación correcta
- Comparador personalizado (`IEqualityComparer<T>`) para diferentes criterios

**2. Operaciones de conjuntos complejas:**

- `UnionWith()` - Combinar permisos
- `IntersectWith()` - Usuarios con múltiples roles
- `ExceptWith()` - Encontrar diferencias para sincronización

**3. Casos de uso del mundo real:**

- Sistema de gestión de usuarios
- Control de duplicados por email
- Análisis de roles y permisos
- Sincronización con sistemas externos

**4. Optimizaciones de rendimiento:**

- Búsquedas O(1) para validaciones
- Operaciones eficientes en grandes conjuntos de datos
- Uso de LINQ con HashSet para consultas complejas

**5. Patrones avanzados:**

- Múltiples HashSet para diferentes propósitos
- Combinación con LINQ para análisis
- Gestión de estado con operaciones de conjuntos

```c#
using System;
using System.Collections.Generic;
using System.Linq;

// Clase personalizada para demostrar HashSet con objetos complejos
public class Usuario
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Email { get; set; }
    public HashSet<string> Roles { get; set; }
    public DateTime FechaRegistro { get; set; }

    public Usuario(int id, string nombre, string email)
    {
        Id = id;
        Nombre = nombre;
        Email = email;
        Roles = new HashSet<string>();
        FechaRegistro = DateTime.Now;
    }

    // Override Equals y GetHashCode para que HashSet funcione correctamente
    public override bool Equals(object obj)
    {
        if (obj is Usuario otro)
            return Id == otro.Id;
        return false;
    }

    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }

    public override string ToString()
    {
        return $"Usuario: {Nombre} ({Email}) - Roles: [{string.Join(", ", Roles)}]";
    }
}

// Comparador personalizado para diferentes criterios de comparación
public class UsuarioEmailComparer : IEqualityComparer<Usuario>
{
    public bool Equals(Usuario x, Usuario y)
    {
        return x?.Email?.ToLower() == y?.Email?.ToLower();
    }

    public int GetHashCode(Usuario obj)
    {
        return obj?.Email?.ToLower().GetHashCode() ?? 0;
    }
}

public class SistemaGestionUsuarios
{
    private HashSet<Usuario> usuariosActivos;
    private HashSet<Usuario> usuariosBloqueados;
    private HashSet<Usuario> usuariosPorEmail; // Usando comparador personalizado

    public SistemaGestionUsuarios()
    {
        usuariosActivos = new HashSet<Usuario>();
        usuariosBloqueados = new HashSet<Usuario>();
        usuariosPorEmail = new HashSet<Usuario>(new UsuarioEmailComparer());
    }

    // Registro de usuario con validaciones avanzadas
    public bool RegistrarUsuario(Usuario usuario, params string[] roles)
    {
        // Verificar duplicados por email usando comparador personalizado
        if (usuariosPorEmail.Contains(usuario))
        {
            Console.WriteLine($"❌ Error: Ya existe un usuario con el email {usuario.Email}");
            return false;
        }

        // Agregar roles al usuario
        foreach (var rol in roles)
        {
            usuario.Roles.Add(rol);
        }

        // Registrar en todas las colecciones
        usuariosActivos.Add(usuario);
        usuariosPorEmail.Add(usuario);

        Console.WriteLine($"✅ Usuario registrado: {usuario}");
        return true;
    }

    // Operaciones avanzadas con conjuntos
    public void AnalisisRoles()
    {
        Console.WriteLine("\n=== ANÁLISIS DE ROLES ===");

        // Obtener todos los roles únicos del sistema
        var todosLosRoles = usuariosActivos
            .SelectMany(u => u.Roles)
            .ToHashSet();

        Console.WriteLine($"Roles en el sistema: {string.Join(", ", todosLosRoles)}");

        // Usuarios con roles específicos
        var admins = usuariosActivos.Where(u => u.Roles.Contains("Admin")).ToHashSet();
        var moderadores = usuariosActivos.Where(u => u.Roles.Contains("Moderador")).ToHashSet();

        Console.WriteLine($"Administradores: {admins.Count}");
        Console.WriteLine($"Moderadores: {moderadores.Count}");

        // Usuarios con múltiples roles (intersección)
        var adminYModerador = new HashSet<Usuario>(admins);
        adminYModerador.IntersectWith(moderadores);
        
        if (adminYModerador.Any())
        {
            Console.WriteLine("Usuarios con roles de Admin y Moderador:");
            foreach (var usuario in adminYModerador)
            {
                Console.WriteLine($"  - {usuario.Nombre}");
            }
        }
    }

    // Gestión avanzada de permisos usando operaciones de conjuntos
    public void GestionarPermisos(string rolObjetivo, HashSet<string> nuevosPermisos)
    {
        Console.WriteLine($"\n=== GESTIÓN DE PERMISOS PARA ROL: {rolObjetivo} ===");

        var usuariosConRol = usuariosActivos.Where(u => u.Roles.Contains(rolObjetivo)).ToList();

        foreach (var usuario in usuariosConRol)
        {
            // Unir permisos existentes con nuevos (simulando permisos como roles adicionales)
            var permisosAnteriores = new HashSet<string>(usuario.Roles);
            usuario.Roles.UnionWith(nuevosPermisos);

            var permisosNuevos = new HashSet<string>(usuario.Roles);
            permisosNuevos.ExceptWith(permisosAnteriores);

            if (permisosNuevos.Any())
            {
                Console.WriteLine($"  {usuario.Nombre}: +{string.Join(", ", permisosNuevos)}");
            }
        }
    }

    // Filtrado avanzado y estadísticas
    public void EstadisticasAvanzadas()
    {
        Console.WriteLine("\n=== ESTADÍSTICAS AVANZADAS ===");

        // Usuarios registrados en los últimos 30 días
        var fechaLimite = DateTime.Now.AddDays(-30);
        var usuariosRecientes = usuariosActivos
            .Where(u => u.FechaRegistro >= fechaLimite)
            .ToHashSet();

        Console.WriteLine($"Usuarios registrados en los últimos 30 días: {usuariosRecientes.Count}");

        // Distribución de roles
        var distribucionRoles = usuariosActivos
            .SelectMany(u => u.Roles)
            .GroupBy(rol => rol)
            .ToDictionary(g => g.Key, g => g.Count());

        Console.WriteLine("Distribución de roles:");
        foreach (var kvp in distribucionRoles.OrderByDescending(x => x.Value))
        {
            Console.WriteLine($"  {kvp.Key}: {kvp.Value} usuarios");
        }

        // Usuarios sin roles específicos
        var usuariosSinRoles = usuariosActivos.Where(u => !u.Roles.Any()).ToHashSet();
        if (usuariosSinRoles.Any())
        {
            Console.WriteLine($"⚠️  Usuarios sin roles: {usuariosSinRoles.Count}");
        }
    }

    // Migración y sincronización usando operaciones de conjuntos
    public void SincronizarConSistemaExterno(HashSet<Usuario> usuariosExternos)
    {
        Console.WriteLine("\n=== SINCRONIZACIÓN CON SISTEMA EXTERNO ===");

        // Usuarios que están en el sistema externo pero no en el local
        var usuariosParaAgregar = new HashSet<Usuario>(usuariosExternos);
        usuariosParaAgregar.ExceptWith(usuariosActivos);

        // Usuarios que están en el local pero no en el externo (posiblemente eliminados)
        var usuariosParaRevisar = new HashSet<Usuario>(usuariosActivos);
        usuariosParaRevisar.ExceptWith(usuariosExternos);

        // Usuarios comunes (para actualizar)
        var usuariosComunes = new HashSet<Usuario>(usuariosActivos);
        usuariosComunes.IntersectWith(usuariosExternos);

        Console.WriteLine($"Usuarios para agregar: {usuariosParaAgregar.Count}");
        Console.WriteLine($"Usuarios para revisar: {usuariosParaRevisar.Count}");
        Console.WriteLine($"Usuarios comunes: {usuariosComunes.Count}");
    }

    public void MostrarTodosLosUsuarios()
    {
        Console.WriteLine("\n=== USUARIOS ACTIVOS ===");
        foreach (var usuario in usuariosActivos.OrderBy(u => u.Nombre))
        {
            Console.WriteLine(usuario);
        }
    }
}

// Programa principal para demostrar el uso
class Program
{
    static void Main()
    {
        var sistema = new SistemaGestionUsuarios();

        // Crear usuarios de ejemplo
        var usuarios = new[]
        {
            new Usuario(1, "Ana García", "ana@empresa.com"),
            new Usuario(2, "Luis Rodríguez", "luis@empresa.com"),
            new Usuario(3, "María López", "maria@empresa.com"),
            new Usuario(4, "Carlos Mendoza", "carlos@empresa.com"),
            new Usuario(5, "Elena Vargas", "elena@empresa.com")
        };

        // Registrar usuarios con diferentes roles
        sistema.RegistrarUsuario(usuarios[0], "Admin", "Moderador");
        sistema.RegistrarUsuario(usuarios[1], "Usuario", "Moderador");
        sistema.RegistrarUsuario(usuarios[2], "Admin");
        sistema.RegistrarUsuario(usuarios[3], "Usuario");
        sistema.RegistrarUsuario(usuarios[4], "Usuario", "Colaborador");

        // Intentar registrar usuario duplicado (por email)
        var usuarioDuplicado = new Usuario(6, "Ana Duplicate", "ana@empresa.com");
        sistema.RegistrarUsuario(usuarioDuplicado, "Usuario");

        // Mostrar usuarios
        sistema.MostrarTodosLosUsuarios();

        // Realizar análisis avanzados
        sistema.AnalisisRoles();
        sistema.GestionarPermisos("Usuario", new HashSet<string> { "Lectura", "Escritura" });
        sistema.EstadisticasAvanzadas();

        // Simular sincronización
        var usuariosExternos = new HashSet<Usuario>
        {
            usuarios[0], usuarios[1], usuarios[2], // Usuarios existentes
            new Usuario(7, "Nuevo Usuario", "nuevo@empresa.com") // Usuario nuevo
        };
        
        sistema.SincronizarConSistemaExterno(usuariosExternos);

        Console.WriteLine("\n¡Demostración completada!");
    }
}
```



# Modulo 3 Programación Avanzada C#



## Sesión 1: Introducción a la Programación Orientada a Objetos (POO) en C#

En esta sesión, los estudiantes serán introducidos al paradigma de la Programación Orientada a Objetos (POO) aplicando los fundamentos del lenguaje C#. Se explorarán los principios clave que rigen este enfoque —encapsulamiento, herencia, polimorfismo y abstracción—, así como la creación y uso de clases, objetos, métodos y atributos. Mediante ejemplos prácticos, el estudiante aprenderá a construir programas estructurados y reutilizables, entendiendo cómo modelar problemas del mundo real a través de objetos.

#### **Objetivos de la sesión:**

- Comprender qué es la Programación Orientada a Objetos y cómo se aplica en C#.
- Identificar y aplicar los cuatro principios fundamentales de la POO: encapsulamiento, herencia, polimorfismo y abstracción.
- Definir y utilizar clases, atributos, métodos y objetos en programas simples.
- Implementar el uso de propiedades (`get` y `set`) para controlar el acceso a los atributos.
- Utilizar la herencia para crear jerarquías de clases y evitar la duplicación de código.
- Demostrar el polimorfismo mediante la sobreescritura de métodos (`override`) en clases derivadas.
- Aplicar el concepto de abstracción usando clases abstractas y métodos abstractos.

#### **Resultados esperados:**

Al finalizar esta sesión, el estudiante será capaz de:

✅ Comprender el concepto de objeto como instancia de una clase en C#.

✅ Declarar clases con atributos públicos y privados, y definir métodos asociados.

✅ Crear objetos y manipular sus datos a través de métodos y propiedades.

✅ Aplicar el **encapsulamiento** para proteger los datos internos de una clase.

✅ Utilizar la **herencia** para derivar nuevas clases basadas en clases existentes.

✅ Implementar **polimorfismo** para definir comportamientos específicos en clases hijas.

✅ Utilizar **clases abstractas** y métodos abstractos para aplicar el principio de **abstracción**.

✅ Comprender cómo la POO permite diseñar software modular, reutilizable y mantenible.

### 3.1. Programación orientada a Objetos

#### 3.1.1. **Introducción a la Programación Orientada a Objetos (POO) en C#** 🚀

La **Programación Orientada a Objetos (POO)** es un paradigma de programación basado en la creación y manipulación de **objetos**. Se utiliza para modelar el mundo real de una manera más estructurada, facilitando el mantenimiento, reutilización y escalabilidad del código.

------

**Conceptos Claves de POO**

La POO se basa en **cuatro principios fundamentales**:

| Concepto            | Descripción                                                  |
| ------------------- | ------------------------------------------------------------ |
| **Encapsulamiento** | Restringe el acceso a los datos y métodos para proteger la integridad del objeto. |
| **Herencia**        | Permite que una clase derive propiedades y métodos de otra, evitando duplicación de código. |
| **Polimorfismo**    | Habilidad de un objeto para tomar múltiples formas, permitiendo diferentes implementaciones de un mismo método. |
| **Abstracción**     | Oculta detalles innecesarios y expone solo lo relevante de un objeto. |

------

#### **3.1.2. Clases y Objetos**

Una **clase** es una plantilla para crear objetos. Un **objeto** es una instancia de una clase.

**Ejemplo: Definir una clase en C#**

```
using System;

class Persona
{
    // Atributos (propiedades)
    public string Nombre;
    public int Edad;

    // Método (comportamiento)
    public void Presentarse()
    {
        Console.WriteLine($"Hola, soy {Nombre} y tengo {Edad} años.");
    }
}

// Programa principal
class Program
{
    static void Main()
    {
        // Crear un objeto de la clase Persona
        Persona persona1 = new Persona();
        persona1.Nombre = "Carlos";
        persona1.Edad = 30;
        persona1.Presentarse(); // Imprime: "Hola, soy Carlos y tengo 30 años."
    }
}
```

📌 **Explicación:**

- Se define la clase `Persona` con atributos (`Nombre`, `Edad`) y un método (`Presentarse`).
- Se crea un objeto `persona1`, se asignan valores y se llama al método `Presentarse`.

------

## Sesión 2 Herencia, polimorfismo y encapsulamiento

#### 3.1.3. **Encapsulamiento** 🔒

Permite ocultar los detalles internos de un objeto y controlar el acceso a sus atributos.

**Ejemplo usando `private` y `public` con métodos `get` y `set`**

```c#
class Persona
{
    private int edad; // Campo privado

    public int Edad
    {
        get { return edad; } // Permite leer el valor
        set 
        { 
            if (value >= 0) edad = value; // Validación
        }
    }
}

// Programa principal
class Program
{
    static void Main()
    {
        Persona persona = new Persona();
        persona.Edad = -5; // No cambiará porque la validación lo impide
        Console.WriteLine(persona.Edad); // Imprime 0 (valor por defecto)
    }
}
```

📌 **Encapsulamiento con `get` y `set` protege el acceso a la variable `edad`.**

------

#### 3.1.4. **Herencia** 👨‍👩‍👧

Permite que una clase (hija) herede atributos y métodos de otra clase (padre), reutilizando código.

**Ejemplo: Herencia en C#**

```c#
class Animal
{
    public string Nombre;

    public void HacerSonido()
    {
        Console.WriteLine("Este animal hace un sonido.");
    }
}

// Clase Perro hereda de Animal
class Perro : Animal
{
    public void Ladrar()
    {
        Console.WriteLine($"{Nombre} dice: ¡Guau, guau!");
    }
}

class Program
{
    static void Main()
    {
        Perro miPerro = new Perro();
        miPerro.Nombre = "Max";
        miPerro.HacerSonido(); // Método heredado
        miPerro.Ladrar(); // Método propio
    }
}
```

📌 **Explicación:**

- `Perro` hereda de `Animal`, reutilizando el método `HacerSonido()`.
- `Perro` tiene su propio método `Ladrar()`.

------

#### **3.1.5.  Polimorfismo** 🎭

Permite que métodos con el mismo nombre actúen de forma diferente según la clase.

**Ejemplo: Sobreescritura de Métodos (`override`)**

```c#
class Animal
{
    public virtual void HacerSonido()
    {
        Console.WriteLine("El animal hace un sonido.");
    }
}
class Perro : Animal
{
    public override void HacerSonido()
    {
        Console.WriteLine("El perro ladra: ¡Guau guau!");
    }
}
class Program
{
    static void Main()
    {
        Animal miAnimal = new Perro();
        miAnimal.HacerSonido(); // Ejecuta el método del Perro gracias al polimorfismo
    }
}
```

📌 **Explicación:**

- `virtual` permite que `HacerSonido()` se sobrescriba.
- `override` en `Perro` modifica el comportamiento.

------

#### **3.1.6. Abstracción** 📦

Oculta los detalles internos y expone solo lo esencial.

**Ejemplo con Clases Abstractas**

```
abstract class Figura
{
    public abstract double CalcularArea(); // Método abstracto (sin implementación)
}

class Circulo : Figura
{
    private double radio;

    public Circulo(double radio)
    {
        this.radio = radio;
    }

    public override double CalcularArea()
    {
        return Math.PI * radio * radio;
    }
}

class Program
{
    static void Main()
    {
        Figura miFigura = new Circulo(5);
        Console.WriteLine("Área del círculo: " + miFigura.CalcularArea());
    }
}
```

📌 **Explicación:**

- `abstract` obliga a que `CalcularArea()` sea implementado en las clases hijas (`Circulo`).

------

**Conclusión** 🏆

✅ **POO** en **C#** permite escribir código más modular, mantenible y reutilizable.
✅ Los **objetos** son instancias de **clases** y pueden tener atributos y métodos.
✅ **Encapsulamiento** protege los datos y controla el acceso a los mismos.
✅ **Herencia** evita duplicación de código al permitir que una clase herede de otra.
✅ **Polimorfismo** permite que diferentes clases implementen métodos de formas variadas.
✅ **Abstracción** expone solo lo esencial y oculta detalles innecesarios.

## Sesión 3: Relaciones entre clases

En UML, existen varios tipos de relaciones entre clases. En nuestro caso, encontramos los siguientes:

1. **Asociación** (Una clase usa a otra).
2. **Agregación** (Una clase tiene una referencia a otra).
3. **Composición** (Una clase contiene otra de forma más fuerte).
4. **Dependencia** (Una clase depende de otra para ejecutar alguna acción).

#### 3.1.7. Asociación (`Profesor` → `Curso`)

📌 **Concepto**
La **asociación** se da cuando **una clase usa otra clase**, pero ambas pueden existir de forma independiente.

📌 **Ejemplo**
Un **profesor** puede **dar varios cursos**, y un **curso** puede ser dictado por **varios profesores**.
Sin embargo, **un profesor sigue existiendo sin el curso**, y **el curso también sigue existiendo sin el profesor**.

📌 **Diagrama UML**

```lua
Profesor -----> Curso
```

```c#
using System;
using System.Collections.Generic;

public class Profesor
{
    private string nombre;
    private List<Curso> cursos;  // Relación de asociación

    public Profesor(string nombre, List<Curso> cursos)
    {
        this.nombre = nombre;
        this.cursos = cursos;
    }

    public void MostrarCursos()
    {
        foreach (Curso c in cursos)
        {
            Console.WriteLine("Curso: " + c.Nombre);
        }
    }
}
public class Curso
{
    public string Nombre { get; private set; }

    public Curso(string nombre)
    {
        Nombre = nombre;
    }
}

```

**Notas**:

- En C#, el uso de propiedades (`get` y `set`) es común. Por eso, `Nombre` en `Curso` se define como una propiedad pública con solo el `get`.
- Se usa `Console.WriteLine` en lugar de `System.out.println`.
- Se capitaliza el nombre de métodos y propiedades según la convención de C# (e.g., `MostrarCursos`, `Nombre`).

📌 **Explicación**

- `Profesor` **tiene una relación con `Curso`**, pero **no depende completamente de él**.
- `Curso` **también puede existir sin `Profesor`**.
- **Si borramos un `Profesor`, los `Cursos` siguen existiendo.**

#### 3.1.8. Agregación (`Escuela` → `Alumno`)**

📌 **Concepto**
La **agregación** ocurre cuando **una clase contiene objetos de otra clase, pero estos objetos pueden seguir existiendo sin la clase contenedora**.

📌 **Ejemplo**
Una **escuela tiene alumnos**, pero **los alumnos pueden existir sin la escuela** (pueden cambiarse de escuela o estudiar en casa).

**Diagrama UML**

```lua
Escuela  ◇-----> Alumno
```

```c#
using System;
using System.Collections.Generic;

public class Escuela
{
    private string nombre;
    private List<Alumno> alumnos;  // Relación de agregación

    public Escuela(string nombre)
    {
        this.nombre = nombre;
        this.alumnos = new List<Alumno>();
    }

    public void AgregarAlumno(Alumno alumno)
    {
        alumnos.Add(alumno);
    }

    public void MostrarAlumnos()
    {
        foreach (Alumno a in alumnos)
        {
            Console.WriteLine("Alumno: " + a.Nombre);
        }
    }
}

public class Alumno
{
    public string Nombre { get; private set; }

    public Alumno(string nombre)
    {
        Nombre = nombre;
    }
}


```

📌 **Explicación**

- `Escuela` **contiene una lista de `Alumno`**, pero un **alumno puede existir sin la escuela**.
- **Si borramos `Escuela`, los `Alumno` aún existen.**

#### 3.1.9. **Composición (`Coche` → `Motor`)**

📌 **Concepto**
La **composición** es una relación más fuerte que la agregación.
👉 **Si el objeto contenedor desaparece, los objetos contenidos también desaparecen.**

📌 **Ejemplo**
Un **coche** **tiene un motor**, pero **el motor no puede existir sin el coche**.

📌 **Diagrama UML**

```lua
Coche  ◆-----> Motor
```

📌 **Ejemplo en código:**

```c#
using System;

public class Coche
{
    private Motor motor;  // Relación de composición

    public Coche()
    {
        motor = new Motor(); // El motor se crea dentro del coche
    }

    public void Encender()
    {
        motor.Arrancar();
    }
}

public class Motor
{
    public void Arrancar()
    {
        Console.WriteLine("El motor está encendido.");
    }
}

```

📌 **Explicación**

- `Coche` **tiene un `Motor`**.
- **Si `Coche` se borra, el `Motor` también desaparece.**
- **El `Motor` no tiene sentido sin un `Coche`.**

#### 3.1.9. **Dependencia (`Cliente` → `Factura`)**

📌 **Concepto**
La **dependencia** ocurre cuando **una clase usa otra clase temporalmente dentro de un método**.
👉 **No hay un atributo de la otra clase en la primera clase.**

📌 **Ejemplo**
Un **cliente** puede solicitar **una factura**, pero la factura **no es un atributo permanente del cliente**.

📌 **Diagrama UML**

```lua
Cliente ---> (usa) ---> Factura
```

📌 **Ejemplo en código:**

```c#
using System;

public class Cliente
{
    private string nombre;

    public Cliente(string nombre)
    {
        this.nombre = nombre;
    }

    public void SolicitarFactura()
    {
        Factura factura = new Factura();  // Se crea temporalmente
        factura.Generar();
    }
}

public class Factura
{
    public void Generar()
    {
        Console.WriteLine("Factura generada.");
    }
}

```

📌 **Explicación**

- `Cliente` **usa `Factura`, pero no la almacena como atributo**.
- **La `Factura` es creada dentro del método y desaparece después de usarse.**
- **Si `Cliente` se borra, la `Factura` sigue existiendo (porque solo fue creada temporalmente).**

# Modulo 4: Patrones de software

Este módulo está diseñado para brindar a los estudiantes las herramientas esenciales que les permitirán crear software **robusto, mantenible, reutilizable y preparado para el cambio**. A través del estudio de los **principios SOLID** y los **patrones de diseño creacionales**, los participantes desarrollarán la capacidad de **diseñar arquitecturas limpias** y tomar decisiones fundamentadas en cuanto a la organización de sus sistemas. Se enfatiza el uso de buenas prácticas de programación orientada a objetos en **C#**, presentando ejemplos prácticos, casos reales y desafíos de implementación.

## Objetivos del módulo

- Comprender y aplicar los **principios SOLID** para mejorar la calidad, escalabilidad y mantenimiento del software.
- Identificar violaciones a los principios SOLID y refactorizar código para corregirlas.
- Reconocer la importancia de un **buen diseño de software** y sus características clave: **reutilización**, **modularidad**, **flexibilidad**, **bajo acoplamiento** y **alta cohesión**.
- Entender qué son los **patrones de diseño**, su utilidad y cuándo aplicarlos.
- Implementar patrones creacionales como **Normal Factory**, **Factory Method**, **Abstract Factory** y **Singleton** en C#.
- Diseñar soluciones que permitan **extensibilidad**, **bajo acoplamiento** y **separación de responsabilidades**, apoyándose en **interfaces, polimorfismo y abstracciones**.

## Resultados esperados

Al completar este módulo, el estudiante podrá:

- ✅ Explicar los cinco principios SOLID con sus beneficios y consecuencias prácticas en el diseño orientado a objetos.
- ✅ Detectar y corregir violaciones a los principios SOLID en fragmentos de código existentes.
- ✅ Aplicar adecuadamente los principios SOLID usando estructuras de C# como **interfaces**, **herencia**, **inyección de dependencias**, entre otras.
- ✅ Comprender el propósito y el funcionamiento de los principales **patrones de diseño creacionales**.
- ✅ Implementar soluciones flexibles, reutilizables y escalables mediante **Factory Method**, **Abstract Factory** y **Singleton**.
- ✅ Integrar principios SOLID y patrones de diseño para crear **arquitecturas limpias y profesionales** en sus propios proyectos.
- ✅ Argumentar y defender decisiones de diseño basadas en principios y patrones reconocidos en la industria del software.

## Sesión 1: SOLID

En esta sesión, los estudiantes serán introducidos a los cinco principios fundamentales del diseño de software conocidos como **principios SOLID**: **Responsabilidad Única (SRP)**, **Abierto/Cerrado (OCP)**, **Sustitución de Liskov (LSP)**, **Segregación de Interfaces (ISP)** e **Inversión de Dependencias (DIP)**. A través de ejemplos prácticos y ejercicios en **C#**, aprenderán a identificar y aplicar estos principios para crear código **modular, extensible, mantenible y desacoplado**. Esta sesión sienta las bases para construir software profesional y escalable.

### Objetivos de la sesión

- Comprender la importancia de los principios SOLID en el desarrollo de software orientado a objetos.
- Identificar los cinco principios SOLID y el problema que resuelve cada uno.
- Comparar implementaciones que violan un principio con versiones que lo respetan.
- Aplicar cada principio utilizando **interfaces, herencia, polimorfismo e inyección de dependencias en C#**.
- Mejorar el diseño de clases mediante refactorización orientada a principios SOLID.

### Resultados esperados

Al finalizar esta sesión, el estudiante será capaz de:

- ✅ Explicar con sus propias palabras el significado y propósito de cada principio SOLID.
- ✅ Detectar violaciones a los principios SOLID en ejemplos de código.
- ✅ Refactorizar clases y estructuras que no respetan estos principios.
- ✅ Diseñar soluciones orientadas a objetos siguiendo buenas prácticas de diseño con **C#**.
- ✅ Aplicar interfaces y abstracciones para reducir el acoplamiento entre clases.
- ✅ Utilizar polimorfismo e inyección de dependencias para cumplir con OCP y DIP.

### 4.1. Principios de diseño (SOLID)

![](https://i.ibb.co/n8ZGRDMV/image.png)

#### 4.1.1. Single responsibility principle (SRP)  

El **Principio de Responsabilidad Única** (*Single Responsibility Principle*, SRP) establece que cada módulo, clase o función dentro de un software debe tener una única razón para cambiar. Es decir, su responsabilidad debe estar bien definida y no debe abarcar múltiples funciones o propósitos dentro del sistema.

**Explicación Detallada**

- **Evita la acumulación de responsabilidades:** Si una clase o función maneja múltiples tareas, cualquier cambio en una de ellas puede afectar a las demás, lo que dificulta el mantenimiento y aumenta el riesgo de errores.
- **Mejora la modularidad:** Al asignar una sola responsabilidad a cada módulo, se facilita la reutilización del código y se reduce el acoplamiento entre componentes.
- **Encapsulación efectiva:** Todo lo relacionado con una responsabilidad específica debe estar dentro del mismo módulo, evitando la dispersión del código.

**Ejemplo: Gestión de Usuarios en un Sistema**

Imaginemos un módulo que gestiona tanto la información de los usuarios como el envío de notificaciones a estos. En este caso, el módulo podría cambiar por dos razones:

1. **Cambio en la estructura de los datos del usuario** (por ejemplo, agregar un nuevo campo como la fecha de nacimiento).
2. **Cambio en la forma en que se envían las notificaciones** (por ejemplo, cambiar de correo electrónico a notificaciones push).

Estas dos funcionalidades son independientes, ya que una afecta **la gestión de datos** y la otra **la comunicación con el usuario**. Según el **Principio de Responsabilidad Única**, estas responsabilidades deben separarse en módulos distintos.

**❌ Diseño Incorrecto (Viola SRP)**

En este caso, la clase `UserManager` tiene dos responsabilidades:

1. **Gestionar los datos del usuario** (almacenar en la base de datos).
2. **Enviar notificaciones al usuario** (correo electrónico, SMS, etc.).

```c#
public class Report
{
    public void GenerateReport()
    {
        // Generar el reporte
        Console.WriteLine("📄 Reporte generado.");
    }

    public void SaveToFile()
    {
        // Guardar el reporte en un archivo
        Console.WriteLine("💾 Reporte guardado en archivo.");
    }
}
```

En este caso, la clase `Report` **viola el SRP** porque tiene dos razones para cambiar: la lógica de generación del reporte **y** la lógica de almacenamiento del reporte.

**Diseño Correcto en C# (aplicando SRP)**

```c#
public class Report
{
    public void GenerateReport()
    {
        // Generar el reporte
        Console.WriteLine("📄 Reporte generado.");
    }
}

public class ReportSaver
{
    public void SaveToFile(Report report)
    {
        // Guardar el reporte en un archivo
        Console.WriteLine("💾 Reporte guardado en archivo.");
    }
}
```

- `Report` **solo se encarga de generar** el reporte.
- `ReportSaver` **solo se encarga de guardar** el reporte.

Esto hace que el sistema sea **más mantenible**, **escalable** y respeta el principio **SRP (Single Responsibility Principle)** del conjunto de principios **SOLID**.

#### 4.1.2 Open/closed principle (OCP)

El **Principio de Abierto/Cerrado (OCP)** establece que una entidad de software (clase, módulo, función) **debe estar abierta para su extensión pero cerrada para su modificación**. Esto significa que podemos añadir nuevas funcionalidades sin necesidad de modificar el código existente, lo que mejora la mantenibilidad y reduce el riesgo de errores.

**🔴 Ejemplo Incorrecto (Viola OCP)**

Imaginemos una aplicación que procesa pagos. Tenemos una clase `PaymentProcessor` que maneja pagos con tarjeta de crédito, pero luego queremos agregar otro método de pago, como PayPal. Si seguimos este enfoque, **debemos modificar la clase existente cada vez que agregamos un nuevo método de pago**, lo que viola OCP.

```java
using System;

class PaymentProcessor
{
    public void ProcessPayment(string type)
    {
        if (type == "credit")
        {
            Console.WriteLine("Processing credit card payment");
        }
        else if (type == "paypal")
        {
            Console.WriteLine("Processing PayPal payment");
        }
        else
        {
            Console.WriteLine("Unsupported payment method");
        }
    }
}

```

**🛑 Problema con este diseño:**

- Cada vez que agregamos un nuevo método de pago, debemos modificar `PaymentProcessor`, lo que **rompe el principio OCP**.
- La clase se vuelve más difícil de mantener y probar.
- Alto **acoplamiento** entre `PaymentProcessor` y los métodos de pago.

✅ Diseño Correcto (Aplicando OCP con Polimorfismo)

Para cumplir con OCP, usamos el **Polimorfismo** creando una interfaz `Payment` y dejando que cada método de pago tenga su propia implementación.

```C#
using System;

// Interfaz para representar cualquier tipo de pago
interface IPayment
{
    void Process();
}

// Implementación para pago con tarjeta de crédito
class CreditCardPayment : IPayment
{
    public void Process()
    {
        Console.WriteLine("Processing credit card payment");
    }
}

// Implementación para pago con PayPal
class PayPalPayment : IPayment
{
    public void Process()
    {
        Console.WriteLine("Processing PayPal payment");
    }
}

// Nueva clase de procesador que sigue OCP
class PaymentProcessor
{
    public void ProcessPayment(IPayment payment)
    {
        payment.Process();
    }
}
// Clase principal para probar el código
class Program
{
    static void Main(string[] args)
    {
        PaymentProcessor processor = new PaymentProcessor();

        IPayment creditCard = new CreditCardPayment();
        IPayment paypal = new PayPalPayment();

        processor.ProcessPayment(creditCard);
        processor.ProcessPayment(paypal);
    }
}

```

#### 4.1.3. Liskov substitution principle (LSP)  

El **Principio de Sustitución de Liskov (LSP)** establece que **las clases derivadas deben poder ser sustituidas por sus clases base sin alterar el comportamiento del programa**.

Esto significa que si una clase `B` hereda de una clase `A`, entonces `B` debe poder reemplazar a `A` sin causar errores o comportamientos inesperados.

> **Regla clave:** Una subclase debe mantener la coherencia con la clase base y no romper sus expectativas.

**🔴 Ejemplo Incorrecto (Viola LSP)**

Supongamos que tenemos una clase base `Bird` con un método `Fly()`, y una subclase `Penguin`. Los pingüinos son aves, pero **no pueden volar**. Si forzamos a la clase `Penguin` a implementar `Fly()`, estamos violando el principio de Liskov.

```C#
using System;
class Bird
{
    public virtual void Fly()
    {
        Console.WriteLine("Flying...");
    }
}
class Sparrow : Bird
{
    // Hereda correctamente sin necesidad de cambios.
}
class Penguin : Bird
{
    public override void Fly()
    {
        throw new NotSupportedException("Penguins can't fly!"); // 🚨 PROBLEMA
    }
}
class Program
{
    static void Main(string[] args)
    {
        Bird sparrow = new Sparrow();
        Bird penguin = new Penguin();

        sparrow.Fly(); // Funciona bien
        penguin.Fly(); // ¡Lanza una excepción! 🚨
    }
}
```

```c#
using System;

// Clase base Bird
class Bird
{
    public string Name { get; set; }

    public Bird(string name)
    {
        Name = name;
    }
}

// Interfaz para aves que pueden volar
interface IFlyable
{
    void Fly();
}

// Gorrión puede volar
class Sparrow : Bird, IFlyable
{
    public Sparrow(string name) : base(name) { }

    public void Fly()
    {
        Console.WriteLine($"{Name} is flying.");
    }
}

// Pingüino NO puede volar, no implementa IFlyable
class Penguin : Bird
{
    public Penguin(string name) : base(name) { }

    public void Swim()
    {
        Console.WriteLine($"{Name} is swimming.");
    }
}

// Programa principal
class Program
{
    static void Main(string[] args)
    {
        IFlyable sparrow = new Sparrow("Jack the Sparrow");
        sparrow.Fly(); // ✅ Funciona bien

        Bird penguin = new Penguin("Pablo el Pingüino");
        // penguin.Fly(); ❌ No permitido, porque Penguin no implementa IFlyable

        ((Penguin)penguin).Swim(); // ✅ Correcto
    }
}
```

Ejemplo usando una clase llamada zoo.

```c#
using System;
using System.Collections.Generic;

// Clase base para todos los pájaros
class Bird
{
    public string Name { get; set; }

    public Bird(string name)
    {
        Name = name;
    }

    public override string ToString() => Name;
}

// Interfaz para pájaros que pueden volar
interface IFlyable
{
    void Fly();
}

// 🐦 Gorrión
class Sparrow : Bird, IFlyable
{
    public Sparrow(string name) : base(name) { }

    public void Fly()
    {
        Console.WriteLine($"{Name} is flying low.");
    }
}

// 🦅 Águila
class Eagle : Bird, IFlyable
{
    public Eagle(string name) : base(name) { }

    public void Fly()
    {
        Console.WriteLine($"{Name} soars high in the sky.");
    }
}

// 🦆 Pato (puede volar y nadar, aquí solo volar)
class Duck : Bird, IFlyable
{
    public Duck(string name) : base(name) { }

    public void Fly()
    {
        Console.WriteLine($"{Name} is flying over the pond.");
    }
}

// 🐧 Pingüino
class Penguin : Bird
{
    public Penguin(string name) : base(name) { }

    public void Swim()
    {
        Console.WriteLine($"{Name} is swimming in the ice water.");
    }
}

// 🏞️ Zoológico que gestiona las aves
class Zoo
{
    public List<Bird> Birds { get; set; } = new List<Bird>();

    public void AddBird(Bird bird)
    {
        Birds.Add(bird);
    }

    public void ShowFlyingBirds()
    {
        Console.WriteLine("🕊️ Birds that can fly:");
        foreach (var bird in Birds)
        {
            if (bird is IFlyable flyable)
            {
                flyable.Fly();
            }
        }
    }

    public void ShowSwimmingBirds()
    {
        Console.WriteLine("🌊 Birds that swim:");
        foreach (var bird in Birds)
        {
            if (bird is Penguin penguin)
            {
                penguin.Swim();
            }
        }
    }
}

// 🔧 Programa principal
class Program
{
    static void Main(string[] args)
    {
        Zoo zoo = new Zoo();

        zoo.AddBird(new Sparrow("Sparrow Jack"));
        zoo.AddBird(new Eagle("Eagle Sky"));
        zoo.AddBird(new Duck("Duck Donald"));
        zoo.AddBird(new Penguin("Penguin Pablo"));

        zoo.ShowFlyingBirds();
        Console.WriteLine();
        zoo.ShowSwimmingBirds();
    }
}
```

#### 4.1.4 Interface segregation principle (ISP) 

El **Principio de Segregación de Interfaces (ISP)** establece que **una clase no debe verse obligada a implementar métodos que no usa**.

En otras palabras, **las interfaces deben ser específicas y pequeñas**, en lugar de una única interfaz grande que obligue a las clases a implementar métodos irrelevantes para ellas.

> **Regla clave:** Es mejor tener muchas interfaces pequeñas y especializadas en lugar de una interfaz grande y genérica.

**🔴 Ejemplo Incorrecto (Viola ISP)**

Supongamos que tenemos una **interfaz genérica `IWorker`**, que define métodos para trabajar y comer. Sin embargo, algunos trabajadores (como robots) **no necesitan comer**, lo que obliga a implementar métodos innecesarios.

```c#
using System;

interface IWorker
{
    void Work();
    void Eat();
}

// Un humano que trabaja y come
class HumanWorker : IWorker
{
    public void Work()
    {
        Console.WriteLine("Human is working...");
    }

    public void Eat()
    {
        Console.WriteLine("Human is eating...");
    }
}

// Un robot que trabaja pero NO come (¡problema!)
class RobotWorker : IWorker
{
    public void Work()
    {
        Console.WriteLine("Robot is working...");
    }

    public void Eat()
    {
        throw new NotSupportedException("Robots don't eat!"); // 🚨 PROBLEMA
    }
}
```

🔴**Problema**

- `RobotWorker` **se ve obligado** a implementar `eat()`, aunque los robots **no comen**.
- Para "solucionarlo", usamos una excepción en `eat()`, lo cual es **una mala práctica** y **viola ISP**.

**✅ Diseño Correcto (Aplicando ISP con Interfaces Especializadas)**

La solución es **dividir `IWorker` en interfaces más pequeñas y específicas**:

```c#
using System;

// Interfaz para cualquier trabajador
interface IWorkable
{
    void Work();
}

// Interfaz exclusiva para trabajadores que pueden comer
interface IEatable
{
    void Eat();
}

// Un humano que trabaja y come
class HumanWorker : IWorkable, IEatable
{
    public void Work()
    {
        Console.WriteLine("Human is working...");
    }

    public void Eat()
    {
        Console.WriteLine("Human is eating...");
    }
}

// Un robot que solo trabaja (ya no está obligado a implementar Eat)
class RobotWorker : IWorkable
{
    public void Work()
    {
        Console.WriteLine("Robot is working...");
    }
}

// Clase principal para probar la solución
class Program
{
    static void Main(string[] args)
    {
        IWorkable humanWorker = new HumanWorker();
        IWorkable robotWorker = new RobotWorker();

        humanWorker.Work(); // ✅ "Human is working..."

        if (humanWorker is IEatable eater)
        {
            eater.Eat(); // ✅ "Human is eating..."
        }

        robotWorker.Work(); // ✅ "Robot is working..."
        // No se permite llamar a Eat() en robotWorker, pues no implementa IEatable
    }
}
```

**Ventajas de esta solución**

✅ **Cumple con ISP**: `RobotWorker` ya no está obligado a implementar `eat()`.
✅ **Código más limpio y extensible**: Podemos agregar nuevos tipos de trabajadores sin modificar el código existente.
✅ **Menos acoplamiento**: Solo las clases que **realmente** necesitan `eat()` lo implementan.

#### 4.4.5 Dependency inversion principle (DIP)

El **Principio de Inversión de Dependencias (DIP)** establece que:

1. **Los módulos de alto nivel no deben depender de módulos de bajo nivel. Ambos deben depender de abstracciones.**
2. **Las abstracciones no deben depender de los detalles. Los detalles deben depender de las abstracciones.**

Esto significa que en lugar de que una clase dependa directamente de otra clase concreta, debe depender de una **interfaz o abstracción**, lo que hace que el código sea más flexible y fácil de modificar.

> **Regla clave:** Evitar dependencias directas entre clases concretas, favoreciendo las abstracciones (interfaces o clases abstractas).

**🔴 Ejemplo Incorrecto (Viola DIP)**

Aquí, `EmailService` es una clase concreta utilizada por `NotificationService`. Si queremos cambiar la forma de enviar notificaciones (por ejemplo, usar SMS en lugar de correo electrónico), **tenemos que modificar `NotificationService`**, lo que rompe DIP.

```c#
using System;

// Servicio de Email para enviar notificaciones
class EmailService
{
    public void SendEmail(string message)
    {
        Console.WriteLine("Sending Email: " + message);
    }
}

// NotificationService depende directamente de EmailService (violación del DIP)
class NotificationService
{
    private EmailService emailService;

    public NotificationService()
    {
        emailService = new EmailService(); // 🚨 DEPENDENCIA FIJA
    }

    public void SendNotification(string message)
    {
        emailService.SendEmail(message); // 🚨 SOLO ENVÍA EMAILS
    }
}

// Clase principal
class Program
{
    static void Main(string[] args)
    {
        NotificationService notificationService = new NotificationService();
        notificationService.SendNotification("Hello User!");
    }
}

```

🛑 Problema con este diseño:

❌ `NotificationService` está **acoplado** a `EmailService`, es decir `NotificationService` **depende directamente** de `EmailService`, lo que significa que si queremos agregar `SMSService` o `PushNotificationService`, debemos modificar `NotificationService`.

❌**Código acoplado**, lo que dificulta la extensión y prueba del sistema.

❌ No se puede cambiar fácilmente a **SMS, WhatsApp u otro servicio** sin modificar `NotificationService`.
❌ **Rompe DIP** porque una clase de alto nivel depende de una implementación concreta, no de una abstracción.

**✅ Diseño Correcto (Aplicando DIP con Inyección de Dependencias)**

Para cumplir con DIP, en lugar de depender directamente de `EmailService`, creamos una **interfaz `INotificationSender`** que define un contrato genérico para cualquier tipo de notificación.

```c#
using System;

// Interfaz para notificaciones (abstracción)
interface INotifier
{
    void Send(string message);
}

// Implementación concreta: Email
class EmailService : INotifier
{
    public void Send(string message)
    {
        Console.WriteLine("Sending Email: " + message);
    }
}

// NotificationService ahora depende de la abstracción INotifier
class NotificationService
{
    private readonly INotifier notifier;

    // Inyección de dependencia a través del constructor
    public NotificationService(INotifier notifier)
    {
        this.notifier = notifier;
    }

    public void SendNotification(string message)
    {
        notifier.Send(message);
    }
}

// Clase principal
class Program
{
    static void Main(string[] args)
    {
        // Se puede cambiar fácilmente la implementación sin tocar NotificationService
        INotifier notifier = new EmailService(); // Podría ser SMSService, WhatsAppService, etc.
        NotificationService notificationService = new NotificationService(notifier);

        notificationService.SendNotification("Hello User!");
    }
}
```

## Sesión 2 Patrones de diseño

En esta sesión, los estudiantes explorarán el mundo de los **patrones de diseño**, estructuras reutilizables que permiten resolver problemas comunes de arquitectura de software de forma eficaz, clara y mantenible. Se presentará el propósito y las ventajas de aplicar patrones en proyectos reales, con énfasis en **patrones creacionales** como **Normal Factory**, **Factory Method**, **Abstract Factory** y **Singleton**. Además, se discutirá cómo los patrones favorecen la extensibilidad del sistema, promueven la reutilización del código y fortalecen la calidad del diseño.

### Objetivos de la sesión

- Comprender qué son los patrones de diseño y su papel en la construcción de software robusto y escalable.
- Identificar los beneficios de usar patrones en cuanto a **reutilización, extensibilidad y mantenibilidad** del código.
- Diferenciar los principales tipos de **patrones creacionales**, su estructura, ventajas y casos de uso.
- Implementar en C# los patrones **Normal Factory**, **Factory Method**, **Abstract Factory** y **Singleton**.
- Aplicar principios de diseño orientado a objetos para mejorar la arquitectura de soluciones reales usando patrones.

### Resultados esperados

Al finalizar esta sesión, el estudiante será capaz de:

- ✅ Explicar qué es un patrón de diseño y por qué es importante en el desarrollo de software.
- ✅ Reconocer y justificar el uso de patrones creacionales en distintos contextos.
- ✅ Implementar correctamente patrones como **Factory Method** y **Singleton** en C#.
- ✅ Crear fábricas abstractas para manejar múltiples productos y tipos mediante el patrón **Abstract Factory**.
- ✅ Evaluar y mejorar la **extensibilidad y reutilización** del código mediante patrones de diseño.
- ✅ Aplicar prácticas de buen diseño para enfrentar cambios y escalabilidad en sistemas reales.

### 4.2. Patrones de diseño

Un **patrón de diseño** es una solución probada y reutilizable para un problema común en el desarrollo de software. No es un código específico, sino una **guía o estructura** que ayuda a diseñar sistemas más organizados, eficientes y mantenibles.

#### 4.2.1 Características clave

1. **Reutilizable**: Se puede aplicar en diferentes proyectos y lenguajes de programación.
2. **Probado**: Ha sido utilizado y refinado por muchos desarrolladores a lo largo del tiempo.
3. **Estandarizado**: Facilita la comunicación entre desarrolladores porque usa una terminología común.

#### 4.2.2  ¿Por qué usar patrones de diseño?

✅ Ayudan a escribir código más claro y modular.
✅ Facilitan el mantenimiento y la escalabilidad del software.
✅ Evitan la reinvención de la rueda, optimizando el desarrollo.
✅ Mejoran la flexibilidad y la reutilización del código.

> 📌 **Conclusión:** Los patrones de diseño te ayudaran a resolver problemas de arquitectura de software de manera efectiva. 🚀

#### 4.2.3 Porque aprender patrones de diseño

✅ Los patrones de diseño constituyen un conjunto de soluciones verificadas para abordar problemas recurrentes en el diseño de software. Aunque un desarrollador no se enfrente directamente a estos desafíos, el conocimiento de los patrones sigue siendo valioso, ya que proporciona herramientas para resolver diversas situaciones aplicando los principios del diseño orientado a objetos.

✅Los patrones de diseño establecen un lenguaje común que facilita la comunicación dentro de un equipo de desarrollo. Al referirse a un patrón específico, como el Singleton, los miembros del equipo pueden comprender rápidamente la sugerencia sin necesidad de explicaciones adicionales, siempre que estén familiarizados con el concepto y su denominación.

#### 4.2.4 Características del buen diseño

##### 4.2.4.1 Reutilización de código

Los costos y el tiempo son dos de los factores más importantes en el desarrollo de cualquier producto de software. Reducir el tiempo de desarrollo permite ingresar al mercado antes que la competencia, mientras que minimizar los costos libera recursos que pueden destinarse al marketing y a la ampliación del alcance hacia clientes potenciales.

Una de las estrategias más utilizadas para disminuir los costos de desarrollo es la reutilización de código. La lógica detrás de esta práctica es evidente: en lugar de crear una solución desde cero en cada proyecto, resulta más eficiente aprovechar el código existente.

Sin embargo, aunque en teoría esta idea parece beneficiosa, en la práctica puede implicar esfuerzos adicionales. La existencia de acoplamientos rígidos entre componentes, dependencias de clases específicas en lugar de interfaces y operaciones incrustadas en el código pueden limitar su flexibilidad, dificultando su reutilización en diferentes contextos.

El uso de patrones de diseño representa una estrategia efectiva para incrementar la flexibilidad de los componentes de software y facilitar su reutilización. No obstante, en algunos casos, esto puede generar una mayor complejidad en su estructura.

En este contexto, Erich Gamma, uno de los pioneros en el desarrollo de los patrones de diseño, ofrece una reflexión sobre la importancia de estos en la reutilización del código.

> **Erich Gamma**  "Yo veo tres niveles de reutilización.
> **En el nivel más bajo**, reutilizas clases: bibliotecas de clase, contenedores, quizá algunos “equipos” de clases, como contenedor/iterador.
>
> **Los frameworks** se encuentran en el nivel superior. Intentan destilar tus decisiones de diseño. Identifican las abstracciones clave para resolver un problema, las representan con clases y definen relaciones entre ellas. JUnit es un pequeño framework, por ejemplo. Es el “¡Hola, mundo!” de los frameworks. Tiene Test , TestCase , TestSuite y las relaciones definidas. 
>
> También hay un **nivel intermedio**. Aquí es donde veo patrones. Los patrones de diseño son más pequeños y más abstractos que los frameworks. En realidad, son una descripción sobre cómo pueden relacionarse un par de clases e interactuar entre sí. El nivel de reutilización aumenta cuando pasas de clases a patrones y por último a frameworks.  Lo bueno de esta capa intermedia es que, a menudo, los patrones ofrecen la reutilización de un modo menos arriesgado que los frameworks. Crear un framework comprende un alto riesgo y una inversión considerable. Los patrones te permiten reutilizar ideas y conceptos de diseño con independencia del código concreto. ""  

##### 4.2.4.2 Extensibilidad 

**El cambio es una constante en la vida de cualquier programador.**

- Un videojuego desarrollado para Windows puede generar demanda para una versión compatible con macOS.
- Un framework de interfaz gráfica diseñado con botones cuadrados puede volverse obsoleto cuando las tendencias favorecen los botones redondos.
- Una arquitectura bien planificada para un sitio de comercio electrónico puede necesitar adaptaciones cuando los clientes solicitan nuevas funcionalidades, como la posibilidad de aceptar pedidos por teléfono.

El desarrollo de software opera en diferentes niveles. En un extremo, están las clases individuales que encapsulan pequeñas unidades de funcionalidad. En el otro, los frameworks, que proporcionan una estructura completa para desarrollar aplicaciones. Existe, sin embargo, un nivel intermedio donde se encuentran los patrones de diseño. Estos representan soluciones más pequeñas y abstractas que los frameworks, describiendo cómo ciertas clases pueden relacionarse e interactuar entre sí.

El nivel de reutilización se incrementa progresivamente: desde clases individuales, pasando por patrones de diseño, hasta llegar a los frameworks. No obstante, los patrones ofrecen un enfoque de reutilización menos riesgoso que los frameworks, ya que estos últimos requieren una inversión significativa y pueden implicar un alto riesgo. En contraste, los patrones permiten reutilizar ideas y conceptos sin depender de una implementación específica del código.

Cada desarrollador puede compartir múltiples experiencias que reflejan la naturaleza cambiante del software. Existen diversas razones para ello:

1. **Mejor comprensión del problema con el tiempo**: Al comenzar a desarrollar una aplicación, la percepción del problema es limitada. Para cuando la primera versión está lista, el entendimiento ha evolucionado tanto que puede parecer más eficiente reescribir el código desde cero. Además, el propio crecimiento profesional del desarrollador puede hacer que su trabajo anterior le parezca ineficiente.
2. **Factores externos fuera de control**: La evolución del entorno tecnológico obliga a realizar cambios constantes. Tecnologías que alguna vez fueron estándar, como Flash, han sido descontinuadas y reemplazadas por soluciones más modernas, lo que ha obligado a muchas empresas a migrar sus aplicaciones.
3. **Cambio en los requisitos del cliente**: Lo que inicialmente parecía una solución ideal puede requerir modificaciones una vez que el cliente la prueba. Su satisfacción con la versión actual puede llevarlo a solicitar nuevas funcionalidades que no fueron contempladas en las primeras etapas del desarrollo.

Por esta razón, los desarrolladores con experiencia diseñan arquitecturas de software preparadas para la evolución y el cambio, asegurando que el sistema pueda adaptarse sin necesidad de reconstruirlo por completo.

#### 4.2.5 Principios del diseño

> Qué es un buen diseño de software? ¿Cómo medimos su calidad? ¿Qué prácticas debemos llevar a cabo para lograrlo? ¿Cómo podemos hacer nuestra arquitectura flexible, estable y fácil de comprender?

**¿Qué es un buen diseño de software?**

Un buen diseño de software es aquel que es **escalable, mantenible, reutilizable y comprensible**. Debe facilitar el desarrollo y la evolución del software, evitando la complejidad innecesaria y permitiendo la integración de nuevas funcionalidades sin afectar negativamente el sistema existente.

**¿Cómo medimos su calidad?**

La calidad del diseño de software se puede medir a través de varios factores clave:

1. **Mantenibilidad**: ¿Es fácil modificar el código sin afectar otras partes del sistema?
2. **Escalabilidad**: ¿Puede adaptarse a un mayor volumen de datos o usuarios sin perder rendimiento?
3. **Reusabilidad**: ¿Se pueden reutilizar módulos en diferentes partes del proyecto o en otros proyectos?
4. **Acoplamiento y cohesión**: ¿Las dependencias entre módulos son mínimas (bajo acoplamiento)? ¿Cada módulo cumple con una única responsabilidad (alta cohesión)?
5. **Flexibilidad**: ¿Es posible extender las funcionalidades sin modificar el código base?
6. **Claridad y legibilidad**: ¿El código es comprensible para otros desarrolladores?

**¿Qué prácticas debemos llevar a cabo para lograrlo?**

Para alcanzar un diseño de software de calidad, es recomendable seguir estas prácticas:

1. **Aplicar los principios SOLID**:
   - **S**ingle Responsibility: Cada clase debe tener una única responsabilidad.
   - **O**pen/Closed: El código debe ser abierto a extensiones, pero cerrado a modificaciones.
   - **L**iskov Substitution: Las subclases deben poder reemplazar a sus superclases sin alterar el comportamiento del programa.
   - **I**nterface Segregation: Es mejor tener múltiples interfaces pequeñas que una única y grande.
   - **D**ependency Inversion: Los módulos de alto nivel no deben depender de los de bajo nivel, sino de abstracciones.
2. **Utilizar patrones de diseño**: Implementar soluciones probadas y reutilizables, como Singleton, Factory, Observer, Strategy, entre otros.
3. **Seguir la arquitectura adecuada**:
   - Arquitectura MVC, Hexagonal, Microservicios, Clean Architecture, según las necesidades del proyecto.
   - Separar la lógica de negocio de la capa de presentación y la de datos.
4. **Mantener un código limpio y estructurado**:
   - Usar nombres descriptivos para variables, métodos y clases.
   - Evitar código duplicado.
   - Aplicar refactorización constante.
5. **Automatizar pruebas**:
   - Implementar **pruebas unitarias** y **pruebas de integración** para asegurar la calidad del código.
6. **Utilizar control de versiones**:
   - Git y buenas prácticas de versionado para gestionar los cambios eficientemente.

**¿Cómo hacer nuestra arquitectura flexible, estable y fácil de comprender?**

Para garantizar una arquitectura que sea **flexible, estable y comprensible**, es recomendable:

✅ **Modularizar el código**: Dividir la aplicación en módulos independientes con responsabilidades bien definidas.
✅ **Diseñar con principios de desacoplamiento**: Usar inyección de dependencias y programar contra interfaces en lugar de implementaciones concretas.
✅ **Adoptar una arquitectura escalable**: Diseñar pensando en el crecimiento del sistema, considerando la posibilidad de distribuir componentes y utilizar bases de datos escalables.
✅ **Documentar adecuadamente**: Escribir documentación clara sobre la estructura del software, los módulos y las decisiones arquitectónicas.
✅ **Realizar revisiones de código**: Fomentar la colaboración en equipo mediante revisiones que aseguren buenas prácticas y mejoren la calidad del código.

> 📌 **Conclusión**: Un buen diseño de software no solo resuelve el problema actual, sino que se anticipa a cambios futuros. Aplicar principios sólidos, patrones de diseño y buenas prácticas garantiza que el sistema sea escalable, flexible y comprensible a largo plazo. 🚀

#### 4.2.6 Patrones Creacionales

Los patrones creacionales nos ayudan a gestionar la manera en que se generan los objetos. En un principio, esto puede parecer inusual, ya que estamos acostumbrados a instanciarlos libremente. No obstante, hay escenarios donde resulta conveniente definir un mecanismo para crear instancias de manera controlada. Esta necesidad puede surgir cuando queremos garantizar que solo exista una única instancia de una clase, cuando no sabemos qué objeto instanciar hasta el tiempo de ejecución o cuando buscamos simplificar la creación de objetos mediante una clase de utilidad. Existen múltiples razones para controlar la creación de objetos, pero lo esencial es ser capaces de reconocerlas y aplicar los patrones creacionales más adecuados para nuestra situación.

A continuación se relacionan los principales patrones creacionales que se van a trabajar en el documento

##### 4.2.6.1. Normal Factory

**Normal Factory** es una implementación básica del **Factory Pattern**, en la que una clase se encarga de la creación de instancias de diferentes objetos según ciertos parámetros o condiciones. A diferencia del **Factory Method**, donde la creación es delegada a subclases, en una **Normal Factory** la lógica de construcción está contenida en una única clase.

**Características principales:**

- Centraliza la creación de objetos en una única clase.
- Permite instanciar diferentes tipos de productos según los parámetros proporcionados.
- Reduce el acoplamiento entre el código cliente y las clases concretas.
- Es más sencilla de implementar que el **Factory Method**, pero menos flexible para extensiones futuras.

**Diferencia entre Normal Factory y Factory Method**

| Característica                         | **Normal Factory**                                           | **Factory Method**                                           |
| -------------------------------------- | ------------------------------------------------------------ | ------------------------------------------------------------ |
| **Ubicación de la lógica de creación** | En una sola clase fábrica.                                   | Delegada a subclases concretas.                              |
| **Flexibilidad**                       | Menos flexible para agregar nuevas clases.                   | Más flexible al permitir la extensión sin modificar el código existente. |
| **Acoplamiento**                       | Menos desacoplado, ya que la fábrica debe conocer todas las clases concretas. | Más desacoplado, ya que el cliente solo depende de interfaces o clases abstractas. |
| **Uso recomendado**                    | Cuando hay pocas clases concretas y no se necesita gran extensibilidad. | Cuando se espera agregar nuevos productos con regularidad.   |

En conclusión, **Normal Factory** es útil en escenarios donde se requiere una creación centralizada y sencilla de objetos, mientras que el **Factory Method** es preferible en sistemas más extensibles y flexibles.

##### 4.2.6.2 **Factory Method**

Se basa en una clase fábrica que contiene métodos para crear objetos de un tipo específico.

**Aplicabilidad** 

- Se recomienda emplear el Método Fábrica cuando no se tiene conocimiento previo sobre las dependencias y los tipos específicos de los objetos con los que el código deberá operar.
- El patrón Factory Method desacopla el código encargado de la creación del producto del código que lo utiliza. Esto facilita la extensión del proceso de construcción del producto sin afectar el resto del código.
- Se debe utilizar el Factory Method cuando se desee proporcionar a los usuarios de una biblioteca o framework un mecanismo para extender sus componentes internos de manera flexible y controlada.
- Se recomienda emplear el Factory Method cuando se busque optimizar el uso de recursos del sistema reutilizando objetos existentes en lugar de instanciarlos nuevamente en cada ocasión.

**Ventajas y Deventajas**  

**Ventajas**

- El Factory Method ayuda a reducir el acoplamiento entre el creador y los productos concretos, permitiendo que el código dependa de interfaces o clases abstractas en lugar de implementaciones específicas. Esto mejora la flexibilidad y mantenibilidad del sistema.
- El Factory Method sigue el **Principio de Responsabilidad Única** al centralizar la lógica de creación de productos en una única clase. Esto permite separar la construcción de objetos del resto del código, facilitando su mantenimiento y reduciendo la complejidad del sistema.
- El Factory Method sigue el **Principio de Abierto/Cerrado**, ya que permite agregar nuevos tipos de productos sin modificar el código cliente existente. Esto se logra definiendo una interfaz común para los productos, permitiendo que nuevas implementaciones sean incorporadas sin alterar la lógica principal del sistema.

**Desventajas**

- El uso del Factory Method puede incrementar la complejidad del código, ya que requiere la creación de múltiples subclases para su correcta implementación. La situación óptima para su aplicación es dentro de una jerarquía de clases creadoras ya existente, donde pueda integrarse de manera natural sin generar una sobrecarga innecesaria en la estructura del sistema.

###### 4.2.6.2.1. Desafíos Extra para Practicar Abstract Factory 🚀**

**🔹 Desafío 1: Gestión de Reportes 📊**

**📌 Descripción:**

Una empresa necesita generar reportes en diferentes formatos:

- **PDF**
- **Excel**
- **CSV**

Cada reporte debe permitir:

1. **Generar el reporte (`generateReport()`)**
2. **Descargar el reporte (`downloadReport()`)**

**Tareas:**

1. Implementa el patrón **Abstract Factory** para generar reportes en diferentes formatos.
2. Crea una fábrica concreta para cada tipo de reporte.
3. El código cliente debe solicitar un formato y recibir el reporte adecuado.

------

**🔹 Desafío 2: Notificaciones Multicanal 📩**

**📌 Descripción:**

Ampliar el sistema de **notificaciones** para soportar nuevos tipos de mensajes:

- **WhatsApp**
- **Telegram**
- **Slack**

Cada notificación debe permitir:

1. **Enviar el mensaje (`sendMessage()`)**
2. **Registrar el mensaje en un log (`logMessage()`)**

**Tareas:**

1. Agrega estas nuevas notificaciones usando **Abstract Factory**.
2. Implementa una fábrica concreta para cada servicio.
3. Permite al código cliente seleccionar el tipo de notificación sin conocer su implementación.

------

**🔹 Desafío 3: Fábrica de Interfaces Gráficas 🎨**

**📌 Descripción:**

Expandir el sistema de **interfaces gráficas** para admitir más entornos:

- **Modo Oscuro**
- **Modo Claro**

Cada tema de UI debe permitir:

1. **Crear un botón estilizado (`createStyledButton()`)**
2. **Crear una barra de navegación (`createNavBar()`)**

**Tareas:**

1. Usa **Abstract Factory** para manejar los diferentes estilos de UI.
2. Crea una fábrica concreta para cada tema.
3. Asegúrate de que los componentes sean compatibles entre sí.

------

**🔹 Desafío 4: Fábrica de Conexiones a APIs 🌐**

**📌 Descripción:**

Se requiere un sistema que pueda conectarse a diferentes APIs según la necesidad:

- **REST API**
- **GraphQL API**
- **SOAP API**

Cada API debe permitir:

1. **Hacer una solicitud (`makeRequest(endpoint)`)**
2. **Obtener datos (`getData()`)**

**Tareas:**

1. Implementa **Abstract Factory** para manejar múltiples tipos de API.
2. Cada API debe tener su propia fábrica concreta.
3. Permite al código cliente seleccionar qué tipo de API utilizar sin conocer su implementación.

### 4.3. Singleton

El **patrón Singleton** es un patrón de diseño **creacional** que garantiza que **solo exista una única instancia** de una clase en toda la aplicación. Además, proporciona un **punto de acceso global** a esa instancia.

Este patrón es útil cuando queremos **restringir la creación de múltiples objetos** de una clase, evitando un uso innecesario de memoria y asegurando un comportamiento **coherente** en toda la aplicación.

#### 4.3.1 ¿Cuándo usar el Patrón Singleton?

Se usa en situaciones donde tener múltiples instancias de una clase podría causar **problemas o ineficiencias**. Algunos ejemplos incluyen:

1. **Gestión de configuración**
   - Se requiere un solo objeto para almacenar configuraciones globales de la aplicación.
2. **Manejo de logs**
   - Es común centralizar el registro de eventos en una única instancia.
3. **Conexión a bases de datos**
   - Crear una nueva conexión a la base de datos cada vez puede ser ineficiente. Un Singleton puede gestionar una conexión reutilizable.
4. **Gestión de caché**
   - Un único objeto maneja los datos en caché para evitar duplicaciones innecesarias.
5. **Gestión de recursos compartidos**
   - Como hilos (threads), sockets o manejadores de archivos.

#### 4.3.2 Características del Patrón Singleton

Para que una clase sea un **Singleton**, debe cumplir con estos tres criterios:

1. **Debe tener un constructor privado**
   - Evita que otras clases puedan instanciarla directamente con `new`.
2. **Debe almacenar su propia instancia como una variable estática privada**
   - Asegura que solo exista una instancia única.
3. **Debe proporcionar un método estático público para obtener la instancia**
   - Permite el acceso global a la única instancia de la clase.

# Modulo 5 Linq

## Sesión 1 Consultas Declarativas con LINQ en C#

En esta sesión, los estudiantes explorarán **LINQ (Language Integrated Query)**, una poderosa herramienta que permite realizar consultas sobre colecciones de datos de manera **declarativa**, concisa y legible directamente en C#. Se analizarán sus beneficios frente al enfoque imperativo tradicional, se explicarán los **diferentes tipos de LINQ** según la fuente de datos (objetos, SQL, XML, JSON, etc.), y se practicará su uso a través de **expresiones lambda y sintaxis de consulta**. Esta sesión tiene como objetivo que los estudiantes comprendan cómo LINQ mejora la productividad, la legibilidad del código y la consistencia en las operaciones sobre datos.

### Objetivos de la sesión

- Comprender qué es LINQ y cómo se integra en el lenguaje C#.
- Diferenciar entre programación **imperativa** y **declarativa**, identificando sus ventajas y desventajas.
- Conocer los principales **tipos de LINQ** y sus aplicaciones en el manejo de datos.
- Usar sintaxis de **consulta** y **métodos de extensión** para filtrar, proyectar y transformar datos.
- Aplicar **expresiones lambda** para crear consultas simples y avanzadas en colecciones.
- Ejecutar ejemplos prácticos utilizando LINQ sobre listas y arrays en memoria.

### Resultados esperados

Al finalizar esta sesión, el estudiante será capaz de:

- ✅ Explicar la diferencia entre programación imperativa y declarativa, y cómo LINQ se relaciona con esta última.
- ✅ Identificar y clasificar los diferentes tipos de LINQ según el tipo de fuente de datos.
- ✅ Usar correctamente la sintaxis de LINQ para realizar consultas sobre colecciones de objetos en C#.
- ✅ Aplicar filtros, condiciones y transformaciones usando métodos como `.Where()`, `.Select()`, `.ToList()`, entre otros.
- ✅ Implementar consultas declarativas sobre arrays y listas utilizando **expresiones lambda** y **sintaxis de consulta**.
- ✅ Comprender cómo LINQ mejora la legibilidad, el mantenimiento y la eficiencia del código en operaciones sobre datos.

### 5.1 Que es Linq

LINQ es un conjunto de métodos y expresiones que permiten escribir consultas de datos directamente en C#. Se introdujo en .NET Framework 3.5 y está disponible en todas las versiones posteriores, incluyendo .NET Core y .NET 5+.

Podemos escribir consultas LINQ para las clases que implementan la interfaz IEnumerable<T> o IQueryable<T>. El espacio de nombres System.Linq incluye las siguientes clases e interfaces necesarias para las consultas LINQ.

![](https://i.ibb.co/1GvVjtk0/image.png)

> El espacio de nombres System.Linq se incluye por defecto cuando se añade una nueva clase en Visual Studio.

#### Enumerable

La clase Enumerable incluye métodos de extensión para las clases que implementan la interfaz IEnumerable<T>, por ejemplo todas las clases de colecciones incorporadas implementan la interfaz IEnumerable<T> y así podemos escribir consultas LINQ para recuperar datos de las colecciones incorporadas.

La siguiente figura muestra los métodos de extensión incluidos en la clase Enumerable que se pueden utilizar con las colecciones genéricas en C# o VB.Net.

![](https://i.ibb.co/zVXZSD1b/image.png)

​							Fuente : https://www.tutorialsteacher.com/linq/linq-api

En la siguiente ilustración se encuentran los métodos de extensión disponibles en la clase `Enumerable`.

![](https://i.ibb.co/N20wskX9/image.png)



#### Queryable

La clase `Queryable` contiene métodos de extensión destinados a clases que implementan la interfaz `IQueryable<T>`. Esta interfaz permite realizar consultas sobre una fuente de datos específica, con un tipo de dato conocido de antemano. Por ejemplo, la API de Entity Framework implementa `IQueryable<T>` para habilitar consultas LINQ sobre bases de datos subyacentes como Microsoft SQL Server.

Además, existen APIs que permiten acceder a datos de terceros. Un ejemplo es LINQ to Amazon, que facilita el uso de LINQ con los servicios web de Amazon para buscar libros u otros productos. Esto es posible implementando la interfaz `IQueryable` para Amazon.

La figura siguiente muestra los métodos de extensión disponibles en la clase `Queryable`, los cuales pueden utilizarse con distintos proveedores de datos, ya sean nativos o de terceros.

<img src="https://i.ibb.co/k2KMpB33/image.png" style="zoom:67%;" />

> ### Métodos de extensión
>
> La lista desplegable contiene métodos como:
>
> - `Aggregate<T>`
> - `All<>`
> - `Any<>`
> - `AsQueryable`
> - `Average`
> - `Cast<>`
> - `Concat<`
>
> Estos son **métodos de extensión** definidos en la clase `Queryable`. Solo se pueden aplicar a colecciones que implementan la interfaz `IQueryable<T>`.
>
> ### Flecha y etiqueta
>
> La flecha indica que estos métodos están diseñados como *extension methods for* (`métodos de extensión para`) tipos que implementan `IQueryable<T>`.
>
> ### Proveedores de datos
>
> El bloque azul muestra ejemplos de tecnologías que implementan `IQueryable<T>` para permitir el uso de LINQ:
>
> - **LINQ to SQL**: permite ejecutar consultas LINQ sobre bases de datos SQL Server.
> - **Entity Framework**: ORM que usa LINQ para consultar bases de datos relacionales.
> - **LINQ to Amazon**: permite usar LINQ para interactuar con servicios de Amazon.
> - **LINQ to LDAP**: permite consultar directorios LDAP usando LINQ.
> - **PLINQ**: versión paralela de LINQ que también implementa `IQueryable<T>` para operaciones en paralelo.
>
> ### `IQueryable<T>`
>
> Es la interfaz que deben implementar las fuentes de datos para que estos métodos de extensión funcionen. Define la capacidad de construir consultas sobre fuentes de datos que pueden ser evaluadas de forma diferida (lazy evaluation), usualmente traducidas a otros lenguajes (como SQL o expresiones LDAP).



### **5.2 Tipos de LINQ**

Existen varios tipos de LINQ dependiendo de la fuente de datos que consultes:

| Tipo de LINQ              | Descripción                                                  |
| ------------------------- | ------------------------------------------------------------ |
| **LINQ to Objects**       | Para consultar listas, arreglos, colecciones en memoria (`List<T>`, `Array`, etc.). |
| **LINQ to SQL**           | Para interactuar con bases de datos SQL usando mapeo objeto-relacional (ORM). |
| **LINQ to Entities**      | Para trabajar con Entity Framework (similar a LINQ to SQL pero más avanzado). |
| **LINQ to XML**           | Para consultar y manipular documentos XML.                   |
| **LINQ to JSON**          | Para procesar JSON usando `System.Text.Json` o `Newtonsoft.Json`. |
| **PLINQ (Parallel LINQ)** | Para ejecutar consultas LINQ en paralelo y mejorar el rendimiento. |

**Beneficios de LINQ:**

- Código más limpio y legible.
- Menos errores, ya que las consultas están tipadas en tiempo de compilación.
- Independencia de la fuente de datos (colecciones, bases de datos, XML, JSON, etc.).
- Soporte para expresiones lambda y funciones anónimas.

### 5.3. Programación declarativa vs. imperativa

La programación imperativa se basa en instrucciones detalladas que indican explícitamente cómo realizar una tarea. En este enfoque, se describe el algoritmo paso a paso, especificando el flujo de control y las acciones a realizar en cada paso. El código imperativo se enfoca en cómo se deben realizar las operaciones y cómo se deben manipular los datos. Ejemplos de lenguajes de programación imperativos son C, C++, C# y Python.

Por otro lado, la programación declarativa se centra en describir qué se desea obtener, sin entrar en los detalles de cómo lograrlo. En lugar de especificar los pasos y acciones específicas, se define el resultado deseado. El código declarativo se enfoca en la lógica y la relación entre los
datos, dejando que el lenguaje o el entorno de programación se encargue de la implementación subyacente. Ejemplos de lenguajes de programación declarativos son SQL (Structured Query Language) utilizado para consultas de bases de datos, HTML (HyperText Markup Language) utilizado para describir la estructura de una página web, y LINQ (Language Integrated Query) que mencioné anteriormente.

En resumen, la programación imperativa se basa en instrucciones detalladas sobre cómo realizar una tarea, mientras que la programación declarativa se enfoca en describir el resultado deseado sin especificar los pasos específicos para lograrlo. Ambos enfoques tienen sus ventajas y se  utilizan en diferentes contextos y paradigmas de programación.  La programación imperativa se basa en instrucciones detalladas que indican explícitamente cómo realizar una tarea. En este enfoque, se describe el algoritmo paso a paso, especificando el flujo de control y las acciones a realizar en cada paso. El código imperativo se enfoca en cómo se deben realizar las operaciones y cómo se deben manipular los datos. Ejemplos de lenguajes de programación imperativos son C, C++, C# y Python.

Por otro lado, la programación declarativa se centra en describir qué se desea obtener, sin entrar en los detalles de cómo lograrlo. En lugar de  especificar los pasos y acciones específicas, se define el resultado deseado. El código declarativo se enfoca en la lógica y la relación entre los
datos, dejando que el lenguaje o el entorno de programación se encargue de la implementación subyacente. Ejemplos de lenguajes de programación declarativos son SQL (Structured Query Language) utilizado para consultas de bases de datos, HTML (HyperText Markup Language) utilizado para describir la estructura de una página web, y LINQ (Language Integrated Query) que mencioné anteriormente.

En resumen, la programación imperativa se basa en instrucciones detalladas sobre cómo realizar una tarea, mientras que la programación declarativa se enfoca en describir el resultado deseado sin especificar los pasos específicos para lograrlo. Ambos enfoques tienen sus ventajas y se utilizan en diferentes contextos y paradigmas de programación.  

Características

| **Característica**          | **Programación Declarativa**                                | **Programación Imperativa**                             |
| --------------------------- | ----------------------------------------------------------- | ------------------------------------------------------- |
| **Definición**              | Paradigma de la programación.                               | Paradigma de la programación.                           |
| **Forma de especificación** | Se especifica **qué** se quiere hacer, no **cómo** hacerlo. | Se especifica **cómo** hacer cada paso de la ejecución. |
| **Estructura**              | Se enfoca en el **resultado final**.                        | Se enfoca en la **secuencia de pasos** a seguir.        |
| **Contraposición**          | Se opone a la programación imperativa.                      | Se opone a la programación declarativa.                 |
| **Simplicidad**             | Más concisa y fácil de escribir.                            | Puede ser más extensa, pero clara en su interpretación. |
| **Ejemplo de uso**          | SQL, LINQ, programación funcional.                          | C, Java, bucles y estructuras de control explícitas.    |

### **5.4 Sintaxis de LINQ**

LINQ tiene dos formas de escribir consultas:

![](https://i.ibb.co/3m2jmWJH/image.png)

**Sintaxis de consulta (Query Syntax)**

```c#
internal class Program
{
    private static void Main(string[] args)
    {
        // string collection
        List<string> strinSkills = new List<string>() {
            "C# Tutorials",
            "SpringBoot",
            "Java",
            "Android and Java" ,
            "C# and .NET Tutorials",
        };

        // LINQ Query Syntax
        var result = from s in strinSkills
                     where s.Contains("Java")
                     select s;
        foreach (var str in result)
		{
			Console.WriteLine(str);
		}
   }
}
```

> **`var result =`**
>  Declara una variable `result` que almacenará el resultado de la consulta LINQ. El tipo se infiere automáticamente.
>
> **`from s in strinSkills`**
>  Define el origen de datos (`strinSkills`) y una variable de iteración `s` que representará cada elemento de la colección.
>
> **`where s.Contains("Java")`**
>  Filtro que selecciona solo los elementos que contienen el texto `"Java"`.
>  El método `Contains` es un método de cadena que retorna `true` si la subcadena `"Java"` está presente en `s`.
>
> **`select s;`**
>  Indica qué valor se devolverá como parte del resultado. En este caso, se retorna el elemento `s` completo.

```c#
internal class Program
{
    private static void Main(string[] args)
    {
        // Student collection
        List<Student> studentList = new List<Student>() {
            new Student() { StudentID = 1, StudentName = "John", Age = 13} ,
            new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
            new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
            new Student() { StudentID = 4, StudentName = "Ram" , Age = 20} ,
            new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
        };

        // LINQ Query Syntax to find out teenager students
        var teenAgerStudent = from s in studentList
                              where s.Age > 12 && s.Age < 20
                              select s;
        // Displaying the teenager students
        Console.WriteLine("Teenager Students:");
        foreach (var student in teenAgerStudent)
        {
            Console.WriteLine($"ID: {student.StudentID}, Name: {student.StudentName}, Age: {student.Age}");
        }

    }
}
public class Student{
	public int StudentID { get; set; }
	public string? StudentName { get; set; }
	public int Age { get; set; }
}
```

### 5.5 Method Syntax

En la sección previa se explicó la sintaxis de consultas en LINQ. Ahora se abordará la sintaxis basada en métodos.

Esta forma, conocida también como sintaxis fluida, emplea métodos de extensión definidos en las clases estáticas `Enumerable` o `Queryable`, de manera similar a como se invoca cualquier método de extensión en C#.

Cabe destacar que, durante la compilación, el compilador traduce automáticamente las expresiones escritas con la sintaxis de consulta a su equivalente en sintaxis de métodos.

```c#
internal class Program
{
    private static void Main(string[] args)
    {
		// string collection
		List<string> stringList = new List<string>() { 
			"C#",
			"VB.NET",
			"Learn C++",
			"Ports and Protocols",
            "Python",
			"MVC JavaScript",
            "ASP.NET MVC",
			"Java" 
		};
		
		// LINQ Method Syntax
		var result = stringList.Where(s => s.Contains("MVC"));
					
		foreach (var str in result)
		{
			Console.WriteLine(str);
		}

    }
}
```

<img src="https://i.ibb.co/4DFTfyV/image.png" style="zoom:67%;" />

```c#
internal class Program
{
    private static void Main(string[] args)
    {
		// string collection
		// Student collection
		List<Student> studentList = new List<Student>() { 
				new Student() { StudentID = 1, StudentName = "John", Age = 13} ,
				new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
				new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
				new Student() { StudentID = 4, StudentName = "Ram" , Age = 20} ,
				new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 } 
		};
		// LINQ Query Method to find out teenager students
		var teenAgerStudent = studentList.Where(s => s.Age > 12 && s.Age < 20);
							  
		Console.WriteLine("Teen age Students:");
						  
		foreach(Student std in teenAgerStudent){			
			Console.WriteLine(std.StudentName);
		}

    }
}
public class Student{

	public int StudentID { get; set; }
	public string? StudentName { get; set; }
	public int Age { get; set; }
	
}
```

### 5.6 Lambda Expression

Una **expresión lambda** en C# es una forma concisa de definir una función anónima (es decir, una función sin nombre) que puede usarse para pasar lógica como argumento a métodos.

> C# 3.0(.NET 3.5) introdujo la expresión lambda junto con LINQ. La expresión lambda es una forma más corta de representar métodos anónimos utilizando una sintaxis especial.

**Ejemplo con delegados**

```c#
internal class Program
{
    delegate bool IsTeenAger(Student stud);
    private static void Main(string[] args)
    {
		IsTeenAger isTeenAger = delegate(Student s) { return s.Age > 12 && s.Age < 20; };
		
		Student stud = new Student() { Age = 18 };
		
		Console.WriteLine(isTeenAger(stud));

    }
}
public class Student{

	public int StudentID { get; set; }
	public string? StudentName { get; set; }
	public int Age { get; set; }
	
}
```

> Un **delegate** en C# es un **tipo seguro** que representa una **referencia a un método**. Es decir, un `delegate` te permite almacenar y ejecutar métodos como si fueran variables.
>
> ------
>
> ### 🔧 ¿Para qué sirve?
>
> Sirve para:
>
> - Pasar métodos como parámetros.
> - Ejecutar métodos de forma flexible (callbacks).
> - Implementar eventos.
> - Usar programación funcional (junto con expresiones lambda).

**Ejemplo con expresiones lambda**

```c#
internal class Program
{
    delegate bool IsTeenAger(Student stud);
    private static void Main(string[] args)
    {
        IsTeenAger isTeenAger = s => s.Age > 12 && s.Age < 20;
        Student stud = new Student() { Age = 18 };
        Console.WriteLine(isTeenAger(stud));
    }
}
public class Student{

	public int StudentID { get; set; }
	public string? StudentName { get; set; }
	public int Age { get; set; }
	
}
```

> La expresión lambda evoluciona a partir del método anónimo eliminando primero la palabra clave delegate y el tipo de parámetro y añadiendo un operador lambda =>.

<img src="https://i.ibb.co/SDLFzg66/image.png" style="zoom:80%;" />



La expresión lambda anterior es absolutamente válida, pero no necesitamos las llaves, el return y el punto y coma si sólo tenemos una sentencia que devuelve un valor. Así que podemos eliminarla.

![](https://i.ibb.co/BHzMXrw3/image.png)

#### 5.6.1 Expresión lambda con múltiples parámetros

Puede encerrar los parámetros entre paréntesis si necesita pasar más de un parámetro, como se indica a continuación:

```c#
(s, youngAge) => s.Age >= youngAge;
```

```c#
using System;

class Program
{
    static void Main()
    {
        // Expresión lambda con dos parámetros (x e y)
        Func<int, int, int> sumar = (x, y) => x + y;

        int resultado = sumar(5, 3);

        Console.WriteLine($"La suma es: {resultado}");
    }
}
```

### 🔍 Explicación:

- `Func<int, int, int>`: representa un delegado que toma **dos enteros** como entrada y devuelve un **entero**.
- `(x, y) => x + y`: es la **expresión lambda** con dos parámetros (`x` e `y`) y una expresión que retorna su suma.



**Si la lambda tuviera más lógica, puedes usar llaves `{}` y `return`:**

```c#
Func<int, int, int> operar = (a, b) =>
{
    int resultado = a * b;
    return resultado;
};
```



### 5.7 Usando Linq

```c#
using System;
using System.Collections.Generic;


internal class Program
{
    private static void Main(string[] args)
    {
        var frutas = new string[] { "Sandia", "Fresas", "Mango", "Ciruelas", "Mango Azucar" };
        var lstMangos = frutas.Where(p => p.StartsWith("Mango")).ToList();
        lstMangos.ForEach(item => Console.WriteLine(item));
    } 
}
```

**Librerías Importadas**

```c#
using System;
using System.Collections.Generic;
```

- **`using System;`** → Se usa para acceder a clases básicas del framework .NET, como `Console`.
- **`using System.Collections.Generic;`** → Se usa para trabajar con colecciones genéricas como `List<T>`. Sin embargo, en este código no es estrictamente necesario porque `List<T>` se usa implícitamente con `.ToList()`.

------

**Definición de la Clase y Método Principal**

```c#
internal class Program
{
    private static void Main(string[] args)
```

- **`internal class Program`** → Define una clase llamada `Program`. La palabra clave `internal` significa que esta clase solo es accesible dentro del ensamblado actual.
- **`private static void Main(string[] args)`** → Este es el **punto de entrada** del programa. Aquí comienza la ejecución.

------

**Declaración del Array de Frutas**

```c#
var frutas = new string[] { "Sandia", "Fresas", "Mango", "Ciruelas", "Mango Azucar" };
```

- **Se declara un array de strings (`string[]`)** llamado `frutas`, que contiene una lista de nombres de frutas.

------

#### **Filtrado con LINQ**

```c#
var lstMangos = frutas.Where(p => p.StartsWith("Mango")).ToList();
```

- `frutas.Where(p => p.StartsWith("Mango"))`:
  - `Where(...)` es un método de LINQ que filtra elementos.
  - `p => p.StartsWith("Mango")` es una **expresión lambda** que revisa si `p` (cada fruta) **comienza con** `"Mango"`.
- **`.ToList()`** → Convierte la consulta LINQ en una lista `List<string>`.

## Sesión 2: Expresiones de Consulta y Cláusulas LINQ en C#

En esta sesión, los estudiantes aprenderán a estructurar consultas completas usando la **sintaxis declarativa de LINQ**. Se explicará qué es una consulta, cómo se diferencia de sus resultados, y cómo se expresa mediante **expresiones de consulta** en C#. Se explorarán las cláusulas más comunes como `from`, `where`, `orderby`, `select`, `group`, `join`, `let` e `into`, y cómo estas se combinan para transformar y consultar datos de forma clara y poderosa. Se pondrá en práctica el uso de **variables de consulta**, se aplicará LINQ sobre arreglos, listas y objetos personalizados, y se consolidarán los conocimientos sobre programación declarativa.

### Objetivos de la sesión

- Comprender la diferencia entre una consulta y su resultado en el contexto de LINQ.
- Identificar y aplicar correctamente las **cláusulas básicas y avanzadas de LINQ** (`from`, `where`, `orderby`, `group`, `select`, `join`, `let`, `into`).
- Utilizar variables de consulta (`IEnumerable` o `IQueryable`) para almacenar y reutilizar estructuras declarativas.
- Implementar consultas con **datos reales** como ciudades, países y productos utilizando LINQ sobre colecciones.
- Reforzar el pensamiento **declarativo**, priorizando el **qué obtener** en lugar del **cómo hacerlo**.

### Resultados esperados

Al finalizar esta sesión, el estudiante será capaz de:

- ✅ Explicar qué es una consulta y en qué se diferencia de su resultado en C#.
- ✅ Construir expresiones de consulta completas usando la sintaxis declarativa de LINQ.
- ✅ Utilizar cláusulas como `where`, `orderby`, `group`, `join` y `let` para filtrar, ordenar, agrupar y transformar datos.
- ✅ Implementar consultas anidadas y múltiples cláusulas dentro de una misma expresión.
- ✅ Aplicar LINQ sobre estructuras complejas como listas de objetos, arreglos anidados y clases personalizadas (`record`).
- ✅ Diferenciar entre una **variable de consulta** y una **variable que almacena resultados**, aplicando buenas prácticas para su uso.

### 5.6 ¿Qué es una consulta y qué hace?

Una *consulta* es un conjunto de instrucciones que describen qué datos se recuperan de uno o varios orígenes de datos determinados y qué forma y qué organización deben tener los datos devueltos. Una consulta es distinta de los resultados que genera.

Por lo general, los datos de origen se organizan lógicamente como una secuencia de elementos del mismo tipo. Por ejemplo, una tabla de base de datos SQL contiene una secuencia de filas. En un archivo XML, hay una "secuencia" de elementos XML (aunque los elementos XML se organizan jerárquicamente en una estructura de árbol). Una colección en memoria contiene una secuencia de objetos.

Desde el punto de vista de la aplicación, el tipo y la estructura específicos de los datos de origen originales no es importante. La aplicación siempre ve los datos de origen como una colección [IEnumerable](https://learn.microsoft.com/es-es/dotnet/api/system.collections.generic.ienumerable-1) o [IQueryable](https://learn.microsoft.com/es-es/dotnet/api/system.linq.iqueryable-1). Por ejemplo, en LINQ to XML, los datos de origen se hacen visibles como `IEnumerable`<[XElement](https://learn.microsoft.com/es-es/dotnet/api/system.xml.linq.xelement)>.

> Obtenido : https://learn.microsoft.com/es-es/dotnet/csharp/linq/get-started/query-expression-basics

### 5.7 ¿Qué es una expresión de consulta?

Una *expresión de consulta* es una consulta que se expresa en sintaxis de consulta. Una expresión de consulta es una construcción de lenguaje de primera clase. Es igual que cualquier otra expresión y puede usarse en cualquier contexto en el que una expresión de C# sea válida. Una expresión de consulta consta de un conjunto de cláusulas escritas en una sintaxis declarativa similar a SQL o XQuery. Cada cláusula contiene una o más expresiones de C#, y estas expresiones pueden ser una expresión de consulta en sí mismas o bien contener una expresión de consulta.

Una expresión de consulta debe comenzar con una cláusula [from](https://learn.microsoft.com/es-es/dotnet/csharp/language-reference/keywords/from-clause) y debe terminar con una cláusula [select](https://learn.microsoft.com/es-es/dotnet/csharp/language-reference/keywords/select-clause) o [group](https://learn.microsoft.com/es-es/dotnet/csharp/language-reference/keywords/group-clause). Entre la primera cláusula `from` y la última cláusula `select` o `group`, puede contener una o varias de estas cláusulas opcionales: [where](https://learn.microsoft.com/es-es/dotnet/csharp/language-reference/keywords/where-clause), [orderby](https://learn.microsoft.com/es-es/dotnet/csharp/language-reference/keywords/orderby-clause), [join](https://learn.microsoft.com/es-es/dotnet/csharp/language-reference/keywords/join-clause), [let](https://learn.microsoft.com/es-es/dotnet/csharp/language-reference/keywords/let-clause) e incluso otras cláusulas [from](https://learn.microsoft.com/es-es/dotnet/csharp/language-reference/keywords/from-clause). También puede usar la palabra clave [`into`](https://learn.microsoft.com/es-es/dotnet/csharp/language-reference/keywords/into) para permitir que el resultado de una cláusula `join` o `group` actúe como origen para más cláusulas de consulta en la misma expresión de consulta. Obtenido : https://learn.microsoft.com/es-es/dotnet/csharp/linq/get-started/query-expression-basics

### **5.8 Uso de diferentes cláusulas en expresiones de consulta**

**🗞Filtrar elementos con `where`**

Queremos obtener estudiantes con notas mayores a 80.

```c#
var estudiantes =
    from e in listaEstudiantes
    where e.Nota > 80
    select e;
```

------

**🗞Ordenar elementos con `orderby`**

Ordenamos los empleados por edad.

```c#
var empleadosOrdenados =
    from e in listaEmpleados
    orderby e.Edad descending
    select e;
```

------

**🗞 Agrupar elementos con `group`**

Agrupamos productos por categoría.

```c#
var productosPorCategoria =
    from p in listaProductos
    group p by p.Categoria into grupo
    select grupo;
```

### 5.9. Variable de consulta

En LINQ, una variable de consulta es cualquier variable que almacene una *consulta* en lugar de los *resultados* de una consulta. Más concretamente, una variable de consulta es siempre un tipo enumerable que genera una secuencia de elementos cuando se itere en una instrucción `foreach` o en una llamada directa a su método [IEnumerator.MoveNext()](https://learn.microsoft.com/es-es/dotnet/api/system.collections.ienumerator.movenext#system-collections-ienumerator-movenext). Obtenido : https://learn.microsoft.com/es-es/dotnet/csharp/linq/get-started/query-expression-basics

Fuente de Datos

```c#
record City(string Name, long Population);
record Country(string Name, double Area, long Population, List<City> Cities);
record Product(string Name, string Category);
```



```c#
static readonly City[] cities = [
    new City("Tokyo", 37_833_000),
    new City("Delhi", 30_290_000),
    new City("Shanghai", 27_110_000),
    new City("São Paulo", 22_043_000),
    new City("Mumbai", 20_412_000),
    new City("Beijing", 20_384_000),
    new City("Cairo", 18_772_000),
    new City("Dhaka", 17_598_000),
    new City("Osaka", 19_281_000),
    new City("New York-Newark", 18_604_000),
    new City("Karachi", 16_094_000),
    new City("Chongqing", 15_872_000),
    new City("Istanbul", 15_029_000),
    new City("Buenos Aires", 15_024_000),
    new City("Kolkata", 14_850_000),
    new City("Lagos", 14_368_000),
    new City("Kinshasa", 14_342_000),
    new City("Manila", 13_923_000),
    new City("Rio de Janeiro", 13_374_000),
    new City("Tianjin", 13_215_000)
];

static readonly Country[] countries = [
    new Country ("Vatican City", 0.44, 526, [new City("Vatican City", 826)]),
    new Country ("Monaco", 2.02, 38_000, [new City("Monte Carlo", 38_000)]),
    new Country ("Nauru", 21, 10_900, [new City("Yaren", 1_100)]),
    new Country ("Tuvalu", 26, 11_600, [new City("Funafuti", 6_200)]),
    new Country ("San Marino", 61, 33_900, [new City("San Marino", 4_500)]),
    new Country ("Liechtenstein", 160, 38_000, [new City("Vaduz", 5_200)]),
    new Country ("Marshall Islands", 181, 58_000, [new City("Majuro", 28_000)]),
    new Country ("Saint Kitts & Nevis", 261, 53_000, [new City("Basseterre", 13_000)])
];
```

Por otro lado, en los dos ejemplos siguientes se muestran variables que no son de consulta, a pesar de que se inicialicen con una consulta. No son variables de consulta porque almacenan resultados:

```c#
var highestScore = (
    from score in scores
    select score
).Max();

// or split the expression
IEnumerable<int> scoreQuery =
    from score in scores
    select score;

var highScore = scoreQuery.Max();
// the following returns the same result
highScore = scores.Max();
```

Obtenido: https://learn.microsoft.com/es-es/dotnet/csharp/linq/get-started/query-expression-basics

#### 5.9.1 Iniciar una expresión de consulta

Una expresión de consulta debe comenzar con una cláusula `from`, que especifica un origen de datos junto con una variable de rango. La variable de rango representa cada elemento sucesivo de la secuencia de origen a medida que esta se recorre. La variable de rango está fuertemente tipada según el tipo de elementos presentes en el origen de datos. En el ejemplo siguiente, como `countries` es una matriz de objetos `Country`, la variable de rango también está tipada como `Country`. Dado que la variable de rango está fuertemente tipada, se puede usar el operador punto para tener acceso a cualquier miembro disponible del tipo. Obtenido: https://learn.microsoft.com/es-es/dotnet/csharp/linq/get-started/query-expression-basics

```c#
using System;
using System.Linq;
namespace baseApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
        //Query syntax
        IEnumerable<Country> countryAreaQuery =
            from country in GeographyData.Countries
            where country.Area > 20 //sq km
            select country;
         }
    }
}
```

#### 5.9.2 Finalizar una expresión de consulta

Una expresión de consulta debe finalizar con una cláusula `group` o `select`.

#### 5.9.3.La cláusula de grupo

Use la cláusula `group` para generar una secuencia de grupos organizados por la clave que especifique. La clave puede ser cualquier tipo de datos. Por ejemplo, la siguiente consulta crea una secuencia de grupos que contienen uno o más objetos `Country` y cuya clave es un tipo `char` con un valor que es la primera letra del nombre de un país. Obtenido: https://learn.microsoft.com/es-es/dotnet/csharp/linq/get-started/query-expression-basics

```c#
var queryCountryGroups =
    from country in countries
    group country by country.Name[0];
```

#### 5.9.4 Filtrar, ordenar y combinar

Entre la cláusula de inicio `from` y la cláusula de finalización `select` o `group`, todas las demás cláusulas (`where`, `join`, `orderby`, `from`, `let`) son opcionales. Cualquier cláusula opcional puede usarse cero veces o varias veces dentro de una consulta. Obtenido: https://learn.microsoft.com/es-es/dotnet/csharp/linq/get-started/query-expression-basics

```
IEnumerable<City> queryCityPop =
    from city in cities
    where city.Population is < 15_000_000 and > 10_000_000
    select city;
```

```
IEnumerable<Country> querySortedCountries =
    from country in countries
    orderby country.Area, country.Population descending
    select country;
```

```
var categoryQuery =
    from cat in categories
    join prod in products on cat equals prod.Category
    select new
    {
        Category = cat,
        Name = prod.Name
    };
```

```
string[] names = ["Svetlana Omelchenko", "Claire O'Donnell", "Sven Mortensen", "Cesar Garcia"];
IEnumerable<string> queryFirstNames =
    from name in names
    let firstName = name.Split(' ')[0]
    select firstName;

foreach (var s in queryFirstNames)
{
    Console.Write(s + " ");
}

//Output: Svetlana Claire Sven Cesar
```

# Modulo 6 Persistencia de datos

La persistencia de datos es un aspecto esencial en el desarrollo de aplicaciones robustas y escalables. En este módulo exploraremos cómo implementar la persistencia en bases de datos MySQL desde una aplicación de consola en C#, aplicando los principios de la **arquitectura hexagonal (puertos y adaptadores)**, la cual permite una alta separación de responsabilidades y facilita el mantenimiento y escalabilidad del software.

A su vez, implementaremos el **patrón de diseño Abstract Factory** para desacoplar la lógica de acceso a datos del dominio de negocio. Esta combinación de enfoques nos permitirá construir una aplicación limpia, orientada a interfaces y fácilmente extensible para soportar múltiples bases de datos o entornos de persistencia.

Utilizaremos Visual Studio Code como entorno de desarrollo y trabajaremos con la librería oficial `MySql.Data` para establecer la conexión con MySQL.

## Objetivo del módulo

El objetivo principal de este módulo es capacitar al estudiante en el desarrollo de una aplicación en C# que integre una base de datos MySQL utilizando una arquitectura desacoplada y mantenible, que se apoye en:

- La **arquitectura hexagonal**, para separar el núcleo de la aplicación de los detalles de infraestructura.
- El **patrón Abstract Factory**, para crear objetos de acceso a datos sin acoplar el código cliente a clases concretas.

## Resultados esperados

Al finalizar este módulo, el estudiante será capaz de:

1. **Comprender los principios de la arquitectura hexagonal**, sus capas y la separación entre puertos (interfaces) y adaptadores (implementaciones).
2. **Aplicar el patrón Abstract Factory** para la creación de repositorios de datos desacoplados del código de aplicación.
3. **Establecer una conexión con MySQL** desde una aplicación de consola en C#.
4. **Desarrollar un flujo básico de consulta de datos** desde una tabla en MySQL usando el patrón de repositorio.
5. **Crear una estructura de proyecto modular**, reutilizable y mantenible, que se puede extender a otras tecnologías (SQLite, PostgreSQL, APIs REST).
6. **Valorar la importancia del desacoplamiento** y el uso de interfaces para fomentar la escalabilidad y las buenas prácticas de desarrollo en C#.

## Sesión 1. Conexión a bases de datos

En esta sesión se abordará uno de los pilares fundamentales en el desarrollo de software profesional: la **conexión a bases de datos** desde una aplicación de consola en **C#**, siguiendo los principios de diseño más robustos y actuales.

El objetivo es que los estudiantes no solo aprendan a conectarse a una base de datos MySQL, sino que lo hagan aplicando buenas prácticas de arquitectura como la **arquitectura hexagonal**, también conocida como **Ports and Adapters**, la cual permite aislar el núcleo del negocio de los detalles técnicos como la persistencia.

Además, se aplicará el patrón de diseño **Abstract Factory**, lo cual permitirá desacoplar la creación de objetos relacionados con la persistencia de datos, facilitando el mantenimiento, la escalabilidad y la posible migración futura a otros motores de bases de datos.

Durante esta sesión, se desarrollará una solución funcional capaz de conectarse a MySQL, consultar registros de una tabla y presentar los datos en consola, todo desde una estructura modular basada en interfaces e implementación por inyección de dependencias.

### Objetivos de la sesión

- Comprender cómo establecer una conexión segura y funcional a una base de datos MySQL desde C#.
- Implementar una arquitectura hexagonal básica en una aplicación de consola.
- Aplicar el patrón Abstract Factory para generar repositorios desacoplados del código de aplicación.
- Construir un flujo completo de lectura de datos desde MySQL respetando los principios SOLID.

### Resultados esperados

Al finalizar esta sesión, el estudiante podrá:

1. Crear una conexión funcional a una base de datos MySQL desde una aplicación de consola en C#.
2. Identificar los componentes principales de la arquitectura hexagonal: dominio, aplicación, puertos y adaptadores.
3. Implementar interfaces de repositorios y sus adaptadores concretos usando `MySql.Data`.
4. Diseñar y aplicar una factoría abstracta para gestionar la creación de conexiones y repositorios.
5. Visualizar datos consultados desde MySQL en consola usando servicios de aplicación desacoplados.

### 6.1 Arquitectura Hexagonal

![](https://i.ibb.co/NgwQDnnp/image.png)

La **arquitectura hexagonal**, también conocida como **arquitectura de puertos y adaptadores**, es un patrón de diseño de software propuesto por **Alistair Cockburn**. Su objetivo principal es desacoplar la lógica de negocio del software de los detalles de implementación, como la interfaz de usuario, la base de datos o cualquier otro servicio externo.

### 🔹**Principios Claves**

1. **Separación de preocupaciones**: Divide la aplicación en capas bien definidas, evitando dependencias directas entre la lógica de negocio y la infraestructura.
2. **Intercambiabilidad**: Permite cambiar la base de datos, interfaz de usuario o cualquier otro componente sin afectar la lógica de negocio.
3. **Testabilidad**: Al estar desacoplada la lógica de negocio, se pueden escribir pruebas unitarias más fácilmente.
4. **Independencia de tecnología**: Se pueden cambiar frameworks, bases de datos o tecnologías sin afectar la aplicación.

### 🛠 **Componentes de la Arquitectura Hexagonal**

La arquitectura se representa como un **hexágono** donde:

- **El núcleo (Core o Dominio)**: Contiene la lógica de negocio pura y no depende de ninguna tecnología externa.
- **Puertos (Ports)**: Son interfaces que definen los puntos de entrada y salida del sistema.
- **Adaptadores (Adapters)**: Implementan los puertos y conectan la aplicación con servicios externos (bases de datos, APIs, UI, etc.).

### 🚀 **Beneficios de la Arquitectura Hexagonal**

✔ **Alta modularidad**: Cada componente se puede desarrollar y probar por separado.
✔ **Fácil mantenimiento y escalabilidad**: Se pueden agregar nuevos adaptadores sin modificar la lógica central.
✔ **Independencia de infraestructura**: Puedes cambiar la base de datos o interfaz sin tocar la lógica del negocio.
✔ **Mayor flexibilidad y pruebas más eficientes**.

### 6.2 Estructura del proyecto (Hexagonal)

```
MiAppHexagonal/
│
├── Application/               <- Lógica del negocio (Core)
│   └── Services/
│       └── ClienteService.cs
│
├── Domain/                    <- Entidades y puertos
│   ├── Entities/
│   │   └── Cliente.cs
│   ├── Ports/
│   │   └── IClienteRepository.cs
│   └── Factory/
│       └── IDbFactory.cs
│
├── Infrastructure/            <- Adaptadores y DB
│   ├── MySQL/
│   │   ├── MySqlDbFactory.cs
│   │   └── MySqlClienteRepository.cs
│
├── Program.cs                 <- Entrada principal
└── MiAppHexagonal.csproj

```

#### 6.2.1 Creación del proyecto

1. Cree una nueva carpeta para almacenar el proyecto, si ya tiene una carpeta de proyectos acceda a la carpeta.

   ![](https://i.ibb.co/1fY7Cgt1/image.png)

2. Ingrese a la carpeta e ingrese el siguiente comando : **dotnet new console -n MiAppHexagonal**

3. Acceda a la carpeta del proyecto y abrala en visual studio code con el comando code .

4. Cree las carpetas de la estructura. Recuerde que las carpetas deben depender de la solución principal

   ![](https://i.ibb.co/Gfz6p0G0/image.png)

5. Instale el controlador de mysql con el comando **dotnet add package MySql.Data**

6. Cree la clase Cliente, Direccion, Pedido y DetallePedido en  Domain/Entities

   ```c#
   using System;
   
   namespace MiAppHexagonal.Domain.Entities;
   
   public class Direccion
   {
       /*
       Asociación (1:1): Direccion
       Relación de asociación simple. Cliente tiene una referencia a Direccion, 
       pero esta puede existir por sí sola.
       */
       public int Id { get; set; }
       public string? Ciudad { get; set; }
       public string? Calle { get; set; }
       public string? CodigoPostal { get; set; }
   }
   
   ```

   ```c#
   using System;
   
   namespace MiAppHexagonal.Domain.Entities;
   
   /*Composición (Pedido → DetallePedido)
   La clase DetallePedido no puede existir sin Pedido, por eso usamos composición.*/
   public class DetallePedido
   {
       public int ProductoId { get; set; }
       public string? NombreProducto { get; set; }
       public int Cantidad { get; set; }
       public decimal PrecioUnitario { get; set; }
       public decimal Total => Cantidad * PrecioUnitario;
   }
   
   ```

   ```c#
   using System;
   
   namespace MiAppHexagonal.Domain.Entities;
   
   public class Pedido
   {
       public int Id { get; set; }
       public DateTime Fecha { get; set; }
   
       // Composición con Detalles
       /*Agregación (1:N): Pedido
           Un cliente tiene múltiples pedidos. Si el cliente se elimina, los pedidos podrían 
           seguir existiendo si hay lógica para migrarlos o archivarlos.
       */
       public List<DetallePedido> Detalles { get; set; } = new();
   }
   
   ```

   ```c#
   using System;
   
   namespace MiAppHexagonal.Domain.Entities;
   
   public class Cliente
   {
       public int Id { get; set; }
       public string? Nombre { get; set; }
   
       // Asociación simple con Dirección (1:1)
       public Direccion? Direccion { get; set; }
   
       // Agregación: un cliente puede tener varios pedidos
       public List<Pedido> Pedidos { get; set; } = new();
   }
   ```

   ```mermaid
   erDiagram
       CLIENTE ||--|| DIRECCION : tiene
       CLIENTE ||--o{ PEDIDO : realiza
       PEDIDO ||--|| CLIENTE : pertenece_a
       PEDIDO ||--o{ DETALLE_PEDIDO : contiene
       DETALLE_PEDIDO ||--|| PEDIDO : pertenece_a
   
       CLIENTE {
           int Id PK
           string Nombre
       }
   
       DIRECCION {
           int Id PK
           string Ciudad
           string Calle
           string CodigoPostal
       }
   
       PEDIDO {
           int Id PK
           DateTime Fecha
       }
   
       DETALLE_PEDIDO {
           int ProductoId PK
           string NombreProducto
           int Cantidad
           decimal PrecioUnitario
       }
   
   ```

   

7. Cree el Puerto o Caso de Uso Domain/Ports/IClienteRepository.cs. Se debe definir como una interface.

   <img src="https://i.ibb.co/xqr28hSW/image.png" style="zoom:80%;" />

   ```c#
   using System;
   using MiAppHexagonal.Domain.Entities;
   
   namespace MiAppHexagonal.Domain.Ports;
   
   public interface IClienteRepository
   {
       List<Cliente> ObtenerTodos();
       void Crear(Cliente cliente);
       void Actualizar(Cliente cliente);
       void Eliminar(int id);
   }
   ```

   8. Cree la clase ClienteService en  Application/Services.

      ```c#
      using System;
      using MiAppHexagonal.Domain.Entities;
      using MiAppHexagonal.Domain.Ports;
      
      namespace MiAppHexagonal.Application.Services;
      
      public class ClienteService
      {
          private readonly IClienteRepository _repo;
      
          public ClienteService(IClienteRepository repo)
          {
              _repo = repo;
          }
      
          public void MostrarTodos()
          {
              var lista = _repo.ObtenerTodos();
              foreach (var c in lista)
              {
                  Console.WriteLine($"ID: {c.Id}, Nombre: {c.Nombre}");
              }
          }
      
          public void CrearCliente(string nombre)
          {
              _repo.Crear(new Cliente { Nombre = nombre });
          }
      
          public void ActualizarCliente(int id, string nuevoNombre)
          {
              _repo.Actualizar(new Cliente { Id = id, Nombre = nuevoNombre });
          }
      
          public void EliminarCliente(int id)
          {
              _repo.Eliminar(id);
          }
      }
      ```

      

   9. Cree la Factory para la conexión a la base de datos.

      ```c#
      using System;
      using MiAppHexagonal.Domain.Ports;
      
      namespace MiAppHexagonal.Domain.Factory;
      
      public interface IDbFactory
      {
          IClienteRepository CrearClienteRepository();
      }
      ```

   10. Cree la clase ConexionSigleton la cual implementara el patron Singleton

       ```c#
       using System;
       using MySql.Data.MySqlClient;
       
       namespace MiAppHexagonal.Infrastructure.Mysql;
       
       public class ConexionSingleton
       {
           private static ConexionSingleton? _instancia;
           private readonly string _connectionString;
           private MySqlConnection? _conexion;
       
           private ConexionSingleton(string connectionString)
           {
               _connectionString = connectionString;
           }
       
           public static ConexionSingleton Instancia(string connectionString)
           {
               _instancia ??= new ConexionSingleton(connectionString);
               return _instancia;
           }
       
           public MySqlConnection ObtenerConexion()
           {
               _conexion ??= new MySqlConnection(_connectionString);
       
               if (_conexion.State != System.Data.ConnectionState.Open)
                   _conexion.Open();
       
               return _conexion;
           }
       }
       ```

   11. Cree la implementación del repositorio del cliente. en Infrastructure cree un folder Repositories

       ```c#
       using System;
       using MiAppHexagonal.Domain.Entities;
       using MiAppHexagonal.Domain.Ports;
       using MiAppHexagonal.Infrastructure.Mysql;
       using MySql.Data.MySqlClient;
       
       namespace MiAppHexagonal.Infrastructure.Repositories;
       
       public class lmpClienteRepository : IClienteRepository
       {
           private readonly ConexionSingleton _conexion;
       
           public lmpClienteRepository(string connectionString)
           {
               _conexion = ConexionSingleton.Instancia(connectionString);
           }
       
           public List<Cliente> ObtenerTodos()
           {
               var clientes = new List<Cliente>();
               var connection = _conexion.ObtenerConexion();
       
               string query = "SELECT id, nombre FROM clientes";
               using var cmd = new MySqlCommand(query, connection);
               using var reader = cmd.ExecuteReader();
       
               while (reader.Read())
               {
                   clientes.Add(new Cliente
                   {
                       Id = reader.GetInt32("id"),
                       Nombre = reader.GetString("nombre")
                   });
               }
       
               return clientes;
           }
       
           public void Crear(Cliente cliente)
           {
               var connection = _conexion.ObtenerConexion();
               string query = "INSERT INTO clientes (nombre) VALUES (@nombre)";
               using var cmd = new MySqlCommand(query, connection);
               cmd.Parameters.AddWithValue("@nombre", cliente.Nombre);
               cmd.ExecuteNonQuery();
           }
       
           public void Actualizar(Cliente cliente)
           {
               var connection = _conexion.ObtenerConexion();
               string query = "UPDATE clientes SET nombre = @nombre WHERE id = @id";
               using var cmd = new MySqlCommand(query, connection);
               cmd.Parameters.AddWithValue("@nombre", cliente.Nombre);
               cmd.Parameters.AddWithValue("@id", cliente.Id);
               cmd.ExecuteNonQuery();
           }
       
           public void Eliminar(int id)
           {
               var connection = _conexion.ObtenerConexion();
               string query = "DELETE FROM clientes WHERE id = @id";
               using var cmd = new MySqlCommand(query, connection);
               cmd.Parameters.AddWithValue("@id", id);
               cmd.ExecuteNonQuery();
           }
       }
       ```

   12. Implemente la Factory creando una clase llamada MySqlDbFactory

       ```c#
       using System;
       using MiAppHexagonal.Domain.Factory;
       using MiAppHexagonal.Domain.Ports;
       using MiAppHexagonal.Infrastructure.Repositories;
       
       namespace MiAppHexagonal.Infrastructure.Mysql;
       
       public class MySqlDbFactory : IDbFactory
       {
           private readonly string _connectionString;
       
           public MySqlDbFactory(string connectionString)
           {
               _connectionString = connectionString;
           }
       
           public IClienteRepository CrearClienteRepository()
           {
               return new lmpClienteRepository(_connectionString);
           }
       }
       ```

   13. Agregue el siguiente codigo a la clase principal program,cs

       ```c#
       using MiAppHexagonal.Application.Services;
       using MiAppHexagonal.Domain.Factory;
       using MiAppHexagonal.Infrastructure.Mysql;
       
       internal class Program
       {
           private static void Main(string[] args)
           {
               string connStr = "server=localhost;database=mi_base;user=mi_usuario;password=mi_contraseña;";
               IDbFactory factory = new MySqlDbFactory(connStr);
               var servicio = new ClienteService(factory.CrearClienteRepository());
                       while (true)
               {
                   Console.WriteLine("\n--- MENÚ CLIENTES ---");
                   Console.WriteLine("1. Mostrar todos");
                   Console.WriteLine("2. Crear nuevo");
                   Console.WriteLine("3. Actualizar");
                   Console.WriteLine("4. Eliminar");
                   Console.WriteLine("0. Salir");
                   Console.Write("Opción: ");
                   var opcion = Console.ReadLine();
                   switch (opcion)
                   {
                       case "1":
                           servicio.MostrarTodos();
                           break;
                       case "2":
                           Console.Write("Nombre: ");
                           servicio.CrearCliente(Console.ReadLine()!);
                           break;
                       case "3":
                           Console.Write("ID a actualizar: ");
                           int idA = int.Parse(Console.ReadLine()!);
                           Console.Write("Nuevo nombre: ");
                           servicio.ActualizarCliente(idA, Console.ReadLine()!);
                           break;
                       case "4":
                           Console.Write("ID a eliminar: ");
                           int idE = int.Parse(Console.ReadLine()!);
                           servicio.EliminarCliente(idE);
                           break;
                       case "0":
                           return;
                       default:
                           Console.WriteLine("❌ Opción inválida.");
                           break;
                   }
               }
           }
       }
       ```

       



Url Git : https://github.com/trainingLeader/MiAppHexagonal.git

Recursos

https://www.tutorialsteacher.com/linq

https://docs.devo.com/space/latest/95191261/Build+a+query+using+LINQ

https://www.netmentor.es/entrada/linq-csharp

