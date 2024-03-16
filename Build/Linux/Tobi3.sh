#!/bin/sh
echo -ne '\033c\033]0;Tobi3\a'
base_path="$(dirname "$(realpath "$0")")"
"$base_path/Tobi3.x86_64" "$@"
