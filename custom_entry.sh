#!/bin/sh
echo foo=${foo}

# TODO : fully load from .env file!
# source /env.conf
export foo=bar #hardcoded for demo purposes

echo foo = ${foo}
dotnet evdemo.dll
