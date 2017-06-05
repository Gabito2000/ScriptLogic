#!/bin/bash


echo "Ingrese el nombre del grupo"
read nombre

if [ -z $nombre ]
then

echo "Debe ingresar un nombre"

else

        ReadGroups=`cat /etc/group | cut -d ':' -f 1 | grep $nombre`
        if [ -z $ReadGroups ]
        then
        	echo "El usuario no existe"

        else

	        userdel $nombre
		ReadGroups=`cat /etc/group | cut -d ':' -f 1 | grep $nombre`

                if [ -z $ReadGroups ]
                then
                        echo "El grupo fue borrado satisfactoriamente"
                        echo "$UID;$USER;$DATE;$TIME;$SHELL;$SSH_CONNECTION;userdel $nombre" >> /var/log/ScriptLogic.log

                else
                        echo "Hubo un error, intentelo nuevamente"

                fi

        fi

fi


