#!/bin/sh
set -e

VOLUME='/home/bf2/srv'
TMP='/home/bf2/tmp'

INSTALLER="$TMP/bf2-linuxded-1.5.3153.0-installer.sh"
INSTALLER_TGZ="$TMP/bf2-linuxded-1.5.3153.0-installer.tgz"
BF2HUB_TGZ="$TMP/BF2Hub-Unranked-Linux-R3.tar.gz"
MODMANAGER_ZIP="$TMP/ModManager-v2.2c.zip"
MONOINSTALLER="$TMP/mono-1.1.12.1_0-installer.bin"
BF2CCD_ZIP="$TMP/BF2CCD_1.4.2446.zip"

# Get required packages
dpkg --add-architecture i386
apt -y update
apt-get -y update
apt-get -y install wget expect unzip libglib2.0-0:i386

# Download missing assets
wget -nc -q --show-progress --progress=bar:force:noscroll -i assets.txt

# Verify checksums
if ! sha512sum -w -c assets.sha512; then
    echo 'Downloaded file checksum mismatch. Exiting.';
    exit 1;
fi

# Extract server files from the installer
tar -xvf $INSTALLER_TGZ -C $TMP
chmod +x $INSTALLER ./extract
./extract

# Download maps from nihlen.net
# NMAPS=('dalian_2_v_2.zip' 'daqing_2_v_2.zip' 'sharqi_2_v_2.zip' 'dragon_2_v_2.zip' '2_v_2_island.zip' '2_v_2_arena.zip' '2v2_ultimate_destination.zip' 'bloody_battle_2_v_2.zip' 'choppa_match.zip' 'cp_abadan.zip' 'darksome_2v2_dalian.zip' 'mash_2_v_2.zip' 'dalian_2_v_2_even.zip' 'dalian_2_v_2_revive.zip' 'daqing_2_v_2_novel.zip' 'dalian_o48.zip' 'nightfall_2_v_2.zip' 'operation2_v_2.zip' 'gulf_of_pwnin_2v2.zip' 'fushe_pass_2v2.zip' '1_sharqi_2v2.zip' 'tactical_zone2_v_2.zip' 'idf_mashtuur_chopper.zip' 'nm_karkand_choppers.zip' 'dogfighting.zip' 'idf_kubra_dam.zip' 'idf_arena.zip' 'idf_gulf.zip' 'tank_battle.zip')

# for i in "${NMAPS[@]}"; do
#     wget https://static.nihlen.net/bf2/maps/$i -O "$TMP/srv/mods/bf2/levels/$i"
#     unzip "$TMP/srv/mods/bf2/levels/$i" -d "$TMP/srv/mods/bf2/levels/"
#     rm "$TMP/srv/mods/bf2/levels/$i"
# done

# Move BF2Hub files into server directory
tar -xvf $BF2HUB_TGZ -C "$TMP/srv"

# Move ModManager files into server directory
unzip $MODMANAGER_ZIP -d "$TMP/srv"

# Install Mono
chmod +x $MONOINSTALLER
$MONOINSTALLER

# Move mono into the server folder so it can be copied to the runtime image
mv /opt/mono-1.1.12.1/ "$TMP/srv/"

# Move BF2CC Daemon into server directory
unzip $BF2CCD_ZIP -d "$TMP/srv/bf2ccd"

# Clean up unused folders (we have updated pb)
rm -r $TMP/srv/pb_* $TMP/srv/bin/ia-32

# Replace with our own BF2 server files (custom settings and scripts)
cp -r "$TMP/bf2/." "$TMP/srv"

# Create empty server folder to copy our files into if it's empty on the host system
mkdir -p $VOLUME
chmod -R 700 $VOLUME/

exit 0
