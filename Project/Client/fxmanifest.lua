-- ssDrones (https://github.com/SparrowStudios/ssDrones)
-- Author: Jacob Paulin (JayPaulinCodes)
-- Created: Jul 29 2023
-- Updated: Aug 7 2023
-- 
-- This Source Code Form is subject to the terms of the Mozilla Public
-- License, v. 2.0. If a copy of the MPL was not distributed with this
-- file, You can obtain one at https://mozilla.org/MPL/2.0/.

fx_version 'cerulean'
games { 'gta5' }

author 'SparrowStudios'
description 'A FiveM Drone Script'
version '1.0.0'

shared_scripts {
	'ssDrones.net.dll'
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
	'stream/ch_prop_ch_arcade_drones.ycd',
	'stream/ch_prop_ch_arcade_drones.ytyp',
	'stream/ch_prop_casino_drone_01a.yft',
	'stream/ch_prop_casino_drone_broken01a.ydr',
	'stream/ch_prop_ch_casino_drones.ycd',
	'stream/ch_prop_ch_casino_drones.ytyp',
}

data_file 'DLC_ITYP_REQUEST' 'stream/ch_prop_ch_arcade_drones.ytyp'
data_file 'DLC_ITYP_REQUEST' 'stream/ch_prop_ch_casino_drones.ytyp'