fx_version 'cerulean'
games { 'gta5' }

author 'SparrowStudios'
description 'A FiveM Drone Script'
version '0.1.0'

shared_scripts {
	'Newtonsoft.Json.dll',
	'ssDrones.net.dll',
}

client_scripts {
	'ssDrones.Client.net.dll'
}

server_scripts {
	'ssDrones.Server.net.dll'
}

files {
  'stream/ch_prop_arcade_drone.ytd',
  'stream/ch_prop_arcade_drone_01a.yft',
  'stream/ch_prop_arcade_drone_01b.yft',
  'stream/ch_prop_arcade_drone_01c.yft',
  'stream/ch_prop_arcade_drone_01d.yft',
  'stream/ch_prop_arcade_drone_01e.yft',
  'stream/ch_prop_ch_arcade_drones.ycd',
  'stream/ch_prop_ch_arcade_drones.ytyp',
  'stream/ch_prop_casino_drone_01a.yft',
  'stream/ch_prop_casino_drone_02a.yft',
  'stream/ch_prop_casino_drone_broken01a.ydr',
  'stream/ch_prop_ch_casino_drones.ycd',
  'stream/ch_prop_ch_casino_drones.ytyp',
}

data_file 'DLC_ITYP_REQUEST' 'stream/ch_prop_ch_arcade_drones.ytyp'
data_file 'DLC_ITYP_REQUEST' 'stream/ch_prop_ch_casino_drones.ytyp'