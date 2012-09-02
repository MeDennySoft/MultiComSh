MultiComSh
==========

MultiComSh es un proyecto donde se pretende generar un software que en cripta de distintas maneras un mensaje  ya sea archivos, texto plano o algo más. Es un proyecto algo complejo que se libera al público una base teórica y un pequeño componente como base.
Fue creado originalmente por Danyel Morales para un grupo de hacking ético que se dedica a ayudar a empresas con baja seguridad en cuanto a aplicaciones en PHP y ASP, por lo que en algún momento se necesito de un método de comunicación mediante el cual se necesitaría enviar mensajes ya sea mediante una RED, por internet o redes sociales.
Un ejemplo de lo que estamos escribiendo será el ambiente que a continuación describimos:


-Un miembro del equipo creaba un mensaje con MultiComSh.

-Suponiendo que era texto plano, este seria encriptado y subido a algun storage externo todo con el software.

-Se generaba una URL y esta era enviada por TWITTER, FACEBOOK O ALGUNA RED SOCIAL.

-La URL era tomada por algunos miembros del equipo y era procesado por MultiComSh.

-Se revelaba el mensaje original.


El plan era que el software lo hiciera todo y muchos de los servicios a utilizar eran:

-PASTEBINS

-TINYPICS

-OTROS


En cuanto a la manera de encriptarlo, todo estaba bien planeado:

Entraría la cadena de texto o archivo al Motor de encriptaciones (CryptoShaurus), posteriormente este realizaría los siguientes pasos:


-La InformationSeed seria enviada a métodos de encriptación, convirtiéndose a algún algoritmo de encriptación.

-Ese mensaje encriptado seria procesado con el Generador QR que aun no esta construido.

-Dentro de la imagen QR generada se encontrara la información de la cryptoInformationSeed.

-Posteriormente seria procesada por un binder de imagen el cual inyectaría de manera encriptado en base 65 la password  general a la imagen QR.

-El nuevo archivo de imagen contendría una password para el proceso contrario dentro de MultiComm, esa password seria una clave pública o privada o incluso ambas.

-El archivo final seria subido automáticamente a algún storage.


Características pensadas:

-Cada componente de MultiCommSh Funcioanria  como un componente independiente de los demás, por lo que no era necesario utilizar a fuerza todos los procesos anteriores.

-100% flexible y programable.

-FREEWARE u OPEN SOURCE.

-Procesar URL para obtener desde el servicio el contenido ya sea imagen o texto y viceversa.

-Procesar los archivos para subirlo a algún servicio automáticamente con la mínima intervención del usuario.

-Comunicación punto a punto con computadoras registradas.

-TODO MEDIANTE ENCRIPTACIÓN

- OTRAS FUNCIONALIDADES
