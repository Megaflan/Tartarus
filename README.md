# Tartarus
A LE&lt;->BE file swapper

Minimum requisites
-----------------------------------------------------------
.NET Framework 4.6.1

Spanish
-----------------------------------------------------------
Abre una consola y aplica los parametros correspondientes junto a la ruta del archivo.
Por ejemplo:
"Tartarus.exe -f -1 "C:\carpeta\archivo.file""
El programa tiene varios parametros y modos de uso.
Los primeros dos parametros que hay que insertar son los siguientes:

	- "-f" para convertir un archivo
	- "-d" para convertir todo un directorio

Tras decidir el modo de uso, debes aplicar otro parametro al lado de este determinando el byte vector,
es decir, el número de bytes que va a convertir antes de pasar al siguiente conjunto.
	
	- "-N" siendo N el número de bytes
	

English
-----------------------------------------------------------
Open a CLI and apply the arguments next to the file's path
For example:
"Tartarus.exe -f "C:\folder\file.file""
The program has various parameters and use modes.
The first two parameters that you need to insert are:

	- "-f" for files conversion
	- "-d" for directories conversion
	
After deciding the use mode, you must apply another parameter next to the previous to determine the byte vector,
in other words, the byte number that it will convert before going to the next array.
	
	- "-N" N being the byte number
	
