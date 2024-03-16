#!/bin/sh
echo -ne '\033c\033]0;2DJ&R\a'
base_path="$(dirname "$(realpath "$0")")"
"$base_path/2DJ&R.x86_64" "$@"
