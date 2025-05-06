cd "$(dirname $0)"
mkdir -p Tundra_NoTimeStop_MOD
mv ./bin/Debug/NoTimeStop_MOD.dll ./Tundra_NoTimeStop_MOD/
zip -r ./Tundra_NoTimeStop_MOD.zip ./Tundra_NoTimeStop_MOD
rm -rf ./Tundra_NoTimeStop_MOD
