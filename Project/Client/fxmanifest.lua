fx_version 'cerulean'
games { 'gta5' }

mono_rt2 'Prerelease expiring 2023-06-30. See https://aka.cfx.re/mono-rt2-preview for info.'

author 'SparrowStudios'
description 'Template Project'
version '0.0.0'

shared_scripts {
	'Newtonsoft.Json.dll',
	'Common.net.dll',
	'Project.net.dll',
}

client_scripts {
	'FxEvents.Client.net.dll',
	'Common.Client.net.dll',
	'Project.Client.net.dll'
}

server_scripts {
	'FxEvents.Server.net.dll',
	'Common.Server.net.dll',
	'Project.Server.net.dll'
}