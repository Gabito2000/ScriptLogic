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
	useradd $nombre
	ReadGroups=`cat /etc/group | cut -d ':' -f 1 | grep $nombre`
	if [ -z $ReadGroups ]
	then
		echo "Hubo un error, intentelo nuevamente"
	else
		echo "El grupo fue creado satisfactoriamente"
		echo "$UID;$USER;$DATE;$TIME;$SHELL;$SSH_CONNECTION;useradd $nombre" >> /var/log/ScriptLogic.log
	fi
	else

	echo "El nombre de grupo ya existe use otro"

	fi

fi



