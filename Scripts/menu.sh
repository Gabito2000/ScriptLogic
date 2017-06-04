#!/bin/bash

echo "***************************"
echo "**    Bienvenido,$USER   **"
echo "** Seleccione una opcion **"
echo "**    1)Crer usuarios    **"
echo "**  2)Modificar usuarios **"
echo "**    3)Borar usuarios   **"
echo "**    4)Crear grupos     **"
echo "**    5)Borar grupos     **"
echo "***************************"
read menu
dir="$(dirname "$0")"

case $menu in
  1) $dir/usuario/creacion.sh ;;
  2) $dir/usuario/borrar.sh ;;
  3) $dir/usuario/modificar.sh ;;
  4) $dir/grupos/creacion.sh ;;
  5) $dir/grupos/borrar.sh ;;
  *) echo "Debe seleccionar una de las opciones"

esac

