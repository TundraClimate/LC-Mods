cd "$(dirname $0)"
mkdir -p Tundra_DoubleQuotaEnergy_MOD
mv ./bin/Debug/DoubleQuotaEnergy_MOD.dll ./Tundra_DoubleQuotaEnergy_MOD/
zip -r ./Tundra_DoubleQuotaEnergy_MOD.zip ./Tundra_DoubleQuotaEnergy_MOD
rm -rf ./Tundra_DoubleQuotaEnergy_MOD
