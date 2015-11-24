S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.2
Build-Number: Z300HDDE0BOK3
Build-Date: 2015.11.09 20:13:02

Crash Information
Process Name: iap-test
PID: 18151
Date: 2015-11-23 14:03:42+0530
Executable File Path: /opt/usr/apps/org.example.iap-test/bin/iap-test
Signal: 6
      (SIGABRT)
      si_code: -6
      signal sent by tkill (sent by pid 18151, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x000046e7
r2   = 0x00000006, r3   = 0xb412e4c0
r4   = 0x00000002, r5   = 0xb412e000
r6   = 0xb682f09c, r7   = 0x0000010c
r8   = 0x00000001, r9   = 0x00000002
r10  = 0x00000007, fp   = 0xbec413c0
ip   = 0x00000000, sp   = 0xbec41184
lr   = 0xb6725f18, pc   = 0xb6724b84
cpsr = 0x200e0010

Memory Information
MemTotal:   986992 KB
MemFree:     67172 KB
Buffers:     14336 KB
Cached:     382356 KB
VmPeak:     140984 KB
VmSize:     137984 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       41192 KB
VmRSS:       38456 KB
VmData:      46100 KB
VmStk:         136 KB
VmExe:          24 KB
VmLib:       41824 KB
VmPTE:         114 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 18151 TID = 18151
18151 18153 18323 18328 

Maps Information
b0dbb000 b15ba000 rw-p [stack:18328]
b15ba000 b15bb000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b15cb000 b15df000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1643000 b1e42000 rw-p [stack:18323]
b1e42000 b1f9d000 r-xp /usr/lib/egl/libMali.so
b1fb2000 b203b000 r-xp /usr/lib/evas/modules/engines/gl_generic/v-1.13/module.so
b2053000 b205d000 r-xp /usr/lib/evas/modules/engines/gl_x11/v-1.13/module.so
b206e000 b207a000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b23bc000 b23c3000 r-xp /usr/lib/libefl-extension.so.0.1.0
b23d4000 b23d8000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.18
b23eb000 b23f1000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b2401000 b2812000 r-xp /opt/usr/apps/org.example.iap-test/bin/iap-test
b298b000 b2a6e000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2aa5000 b2acd000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2adf000 b32de000 rw-p [stack:18153]
b32de000 b32e0000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b32f0000 b32fa000 r-xp /lib/libnss_files-2.20-2014.11.so
b330b000 b3314000 r-xp /lib/libnss_nis-2.20-2014.11.so
b3325000 b3336000 r-xp /lib/libnsl-2.20-2014.11.so
b3349000 b334f000 r-xp /lib/libnss_compat-2.20-2014.11.so
b3360000 b3361000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b3389000 b3390000 r-xp /usr/lib/libminizip.so.1.0.0
b33a0000 b33a5000 r-xp /usr/lib/libstorage.so.0.1
b33b5000 b3426000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b343c000 b3450000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b3460000 b34a4000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b34b4000 b34bc000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b34cc000 b34fc000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b350f000 b35c8000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b35dc000 b3641000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b3652000 b366d000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b367d000 b373e000 r-xp /usr/lib/libprotobuf.so.9.0.1
b3751000 b3762000 r-xp /usr/lib/libefl-assist.so.0.1.0
b3772000 b377f000 r-xp /usr/lib/libmdm-common.so.1.0.97
b3790000 b3797000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b37a7000 b37e8000 r-xp /usr/lib/libmdm.so.1.2.10
b37f8000 b3800000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b380f000 b381f000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b3840000 b38a0000 r-xp /usr/lib/libasound.so.2.0.0
b38b2000 b38b5000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b38c5000 b38c8000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b38d8000 b38dd000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b38ed000 b38ee000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b38fe000 b3909000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b391d000 b3926000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3936000 b393e000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b394e000 b3953000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3963000 b397f000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3990000 b3997000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b39a7000 b39ab000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b39bb000 b39e9000 r-xp /usr/lib/libidn.so.11.5.44
b39f9000 b3a0f000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3a20000 b3a2a000 r-xp /usr/lib/libcares.so.2.1.0
b3a3a000 b3a44000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.29
b3a54000 b3a56000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b3a66000 b3a67000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3a77000 b3a7b000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3a8c000 b3ab7000 r-xp /usr/lib/libui-extension.so.0.1.0
b3ac7000 b3af0000 r-xp /usr/lib/libturbojpeg.so
b3b10000 b3b16000 r-xp /usr/lib/libgif.so.4.1.6
b3b26000 b3b6c000 r-xp /usr/lib/libcurl.so.4.3.0
b3b7d000 b3b9e000 r-xp /usr/lib/libexif.so.12.3.3
b3bb9000 b3bce000 r-xp /usr/lib/libtts.so
b3bdf000 b3be7000 r-xp /usr/lib/libfeedback.so.0.1.4
b3bf8000 b3cbd000 r-xp /usr/lib/libdali-core.so.0.0.0
b3cde000 b3dd5000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3df5000 b3ec3000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3eda000 b3edc000 r-xp /usr/lib/libboost_system.so.1.51.0
b3eec000 b3ef2000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3f02000 b3f25000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3f36000 b3f38000 r-xp /usr/lib/libappsvc.so.0.1.0
b3f48000 b3f4a000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3f5b000 b3f60000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3f77000 b3f79000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3f89000 b3f90000 r-xp /usr/lib/libsensord-share.so
b3fa0000 b3fb8000 r-xp /usr/lib/libsensor.so.1.1.0
b3fc9000 b3fcc000 r-xp /usr/lib/libXv.so.1.0.0
b3fdc000 b3fe1000 r-xp /usr/lib/libutilX.so.1.1.0
b3ff1000 b3ff7000 r-xp /usr/lib/libappcore-common.so.1.1
b4007000 b400e000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b4021000 b4025000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b4036000 b4114000 r-xp /usr/lib/libCOREGL.so.4.0
b4134000 b4137000 r-xp /usr/lib/libuuid.so.1.3.0
b4147000 b415e000 r-xp /usr/lib/libblkid.so.1.1.0
b416f000 b4171000 r-xp /usr/lib/libXau.so.6.0.0
b4181000 b41c8000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b41da000 b41e0000 r-xp /usr/lib/libjson-c.so.2.0.1
b41f1000 b41f5000 r-xp /usr/lib/libogg.so.0.7.1
b4205000 b4227000 r-xp /usr/lib/libvorbis.so.0.4.3
b4237000 b431b000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b4337000 b433a000 r-xp /usr/lib/libEGL.so.1.4
b434b000 b4351000 r-xp /usr/lib/libxcb-render.so.0.0.0
b4361000 b4363000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b4373000 b4380000 r-xp /usr/lib/libGLESv2.so.2.0
b4391000 b43f3000 r-xp /usr/lib/libpixman-1.so.0.28.2
b4408000 b4420000 r-xp /usr/lib/libmount.so.1.1.0
b4432000 b4446000 r-xp /usr/lib/libxcb.so.1.1.0
b4456000 b445d000 r-xp /lib/libcrypt-2.20-2014.11.so
b4495000 b4497000 r-xp /usr/lib/libiri.so
b44a7000 b44b2000 r-xp /usr/lib/libgpg-error.so.0.15.0
b44c3000 b44f9000 r-xp /usr/lib/libpulse.so.0.16.2
b450a000 b454d000 r-xp /usr/lib/libsndfile.so.1.0.25
b4562000 b4577000 r-xp /lib/libexpat.so.1.5.2
b4589000 b4647000 r-xp /usr/lib/libcairo.so.2.11200.14
b465b000 b4663000 r-xp /usr/lib/libdrm.so.2.4.0
b4673000 b4676000 r-xp /usr/lib/libdri2.so.0.0.0
b4686000 b46d4000 r-xp /usr/lib/libssl.so.1.0.0
b46e9000 b46f5000 r-xp /usr/lib/libeeze.so.1.13.0
b4706000 b470f000 r-xp /usr/lib/libethumb.so.1.13.0
b471f000 b4722000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b4732000 b48e9000 r-xp /usr/lib/libcrypto.so.1.0.0
b56d4000 b56dd000 r-xp /usr/lib/libXi.so.6.1.0
b56ed000 b56ef000 r-xp /usr/lib/libXgesture.so.7.0.0
b56ff000 b5703000 r-xp /usr/lib/libXtst.so.6.1.0
b5713000 b5719000 r-xp /usr/lib/libXrender.so.1.3.0
b5729000 b572f000 r-xp /usr/lib/libXrandr.so.2.2.0
b573f000 b5741000 r-xp /usr/lib/libXinerama.so.1.0.0
b5752000 b5755000 r-xp /usr/lib/libXfixes.so.3.1.0
b5765000 b5770000 r-xp /usr/lib/libXext.so.6.4.0
b5780000 b5782000 r-xp /usr/lib/libXdamage.so.1.1.0
b5792000 b5794000 r-xp /usr/lib/libXcomposite.so.1.0.0
b57a4000 b5886000 r-xp /usr/lib/libX11.so.6.3.0
b589a000 b58a1000 r-xp /usr/lib/libXcursor.so.1.0.2
b58b1000 b58c9000 r-xp /usr/lib/libudev.so.1.6.0
b58cb000 b58ce000 r-xp /lib/libattr.so.1.1.0
b58de000 b58fe000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b58ff000 b5904000 r-xp /usr/lib/libffi.so.6.0.2
b5915000 b592d000 r-xp /lib/libz.so.1.2.8
b593d000 b593f000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b594f000 b5a24000 r-xp /usr/lib/libxml2.so.2.9.2
b5a39000 b5ad4000 r-xp /usr/lib/libstdc++.so.6.0.20
b5af0000 b5af3000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5b03000 b5b22000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5b32000 b5b43000 r-xp /lib/libresolv-2.20-2014.11.so
b5b57000 b5bd1000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5be6000 b5be8000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5bf8000 b5bff000 r-xp /usr/lib/libembryo.so.1.13.0
b5c0f000 b5c19000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5c2a000 b5c42000 r-xp /usr/lib/libpng12.so.0.50.0
b5c53000 b5c76000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c97000 b5cab000 r-xp /usr/lib/libector.so.1.13.0
b5cbc000 b5cd4000 r-xp /usr/lib/liblua-5.1.so
b5ce5000 b5d3c000 r-xp /usr/lib/libfreetype.so.6.11.3
b5d50000 b5d78000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d89000 b5d9c000 r-xp /usr/lib/libfribidi.so.0.3.1
b5dad000 b5de7000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5df8000 b5e06000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5e16000 b5e1e000 r-xp /usr/lib/libtbm.so.1.0.0
b5e2e000 b5e3b000 r-xp /usr/lib/libeio.so.1.13.0
b5e4b000 b5e4d000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5e5d000 b5e62000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5e72000 b5e89000 r-xp /usr/lib/libefreet.so.1.13.0
b5e9b000 b5ebb000 r-xp /usr/lib/libeldbus.so.1.13.0
b5ecb000 b5eeb000 r-xp /usr/lib/libecore_con.so.1.13.0
b5eed000 b5ef3000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5f03000 b5f14000 r-xp /usr/lib/libemotion.so.1.13.0
b5f25000 b5f2c000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5f3c000 b5f4b000 r-xp /usr/lib/libeo.so.1.13.0
b5f5c000 b5f6e000 r-xp /usr/lib/libecore_input.so.1.13.0
b5f7f000 b5f84000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f94000 b5fad000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5fbd000 b5fda000 r-xp /usr/lib/libeet.so.1.13.0
b5ff3000 b603b000 r-xp /usr/lib/libeina.so.1.13.0
b604c000 b605c000 r-xp /usr/lib/libefl.so.1.13.0
b606d000 b6152000 r-xp /usr/lib/libicuuc.so.51.1
b616f000 b62af000 r-xp /usr/lib/libicui18n.so.51.1
b62c6000 b62fe000 r-xp /usr/lib/libecore_x.so.1.13.0
b6310000 b6313000 r-xp /lib/libcap.so.2.21
b6323000 b634c000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b635d000 b6364000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6376000 b63ad000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b63be000 b64a9000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b64bc000 b6535000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6547000 b654c000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b655c000 b6567000 r-xp /usr/lib/libvconf.so.0.2.45
b6577000 b6579000 r-xp /usr/lib/libvasum.so.0.3.1
b6589000 b658b000 r-xp /usr/lib/libttrace.so.1.1
b659b000 b659e000 r-xp /usr/lib/libiniparser.so.0
b65ae000 b65d4000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b65e5000 b65ea000 r-xp /usr/lib/libxdgmime.so.1.1.0
b65fb000 b6612000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6623000 b668e000 r-xp /lib/libm-2.20-2014.11.so
b669f000 b66a5000 r-xp /lib/librt-2.20-2014.11.so
b66b6000 b66c3000 r-xp /usr/lib/libunwind.so.8.0.1
b66f9000 b681d000 r-xp /lib/libc-2.20-2014.11.so
b6832000 b684b000 r-xp /lib/libgcc_s-4.9.so.1
b685b000 b693d000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b694e000 b6978000 r-xp /usr/lib/libdbus-1.so.3.8.12
b6989000 b69c5000 r-xp /usr/lib/libsystemd.so.0.4.0
b69c7000 b6a4a000 r-xp /usr/lib/libedje.so.1.13.0
b6a5d000 b6a7b000 r-xp /usr/lib/libecore.so.1.13.0
b6a9b000 b6c23000 r-xp /usr/lib/libevas.so.1.13.0
b6c58000 b6c6c000 r-xp /lib/libpthread-2.20-2014.11.so
b6c80000 b6eb4000 r-xp /usr/lib/libelementary.so.1.13.0
b6ee3000 b6ee7000 r-xp /usr/lib/libsmack.so.1.0.0
b6ef7000 b6efe000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6f0e000 b6f10000 r-xp /usr/lib/libdlog.so.0.0.0
b6f20000 b6f23000 r-xp /usr/lib/libbundle.so.0.1.22
b6f33000 b6f35000 r-xp /lib/libdl-2.20-2014.11.so
b6f46000 b6f5f000 r-xp /usr/lib/libaul.so.0.1.0
b6f72000 b6f78000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f8a000 b6f97000 r-xp /usr/lib/liblptcp.so
b6fa9000 b6fad000 r-xp /usr/lib/libsys-assert.so
b6fbe000 b6fde000 r-xp /lib/ld-2.20-2014.11.so
b6fef000 b6ff5000 r-xp /usr/bin/launchpad-loader
b7fb3000 b8a55000 rw-p [heap]
bec21000 bec42000 rw-p [stack]
b6fef000 b6ff5000 r-xp /usr/bin/launchpad-loader
b7fb3000 b8a55000 rw-p [heap]
bec21000 bec42000 rw-p [stack]
End of Maps Information

Callstack Information (PID:18151)
Call Stack Count: 15
 0: gsignal + 0x34 (0xb6724b84) [/lib/libc.so.6] + 0x2bb84
 1: abort + 0x12c (0xb6725f18) [/lib/libc.so.6] + 0x2cf18
 2: (0xb676046c) [/lib/libc.so.6] + 0x6746c
 3: (0xb67660d4) [/lib/libc.so.6] + 0x6d0d4
 4: (0xb6766a5c) [/lib/libc.so.6] + 0x6da5c
 5: AppDelegate::~AppDelegate() + 0x14 (0xb2433651) [/opt/usr/apps/org.example.iap-test/bin/iap-test] + 0x32651
 6: cocos2d::app_terminate(void*) + 0x2a (0xb24a2dcb) [/opt/usr/apps/org.example.iap-test/bin/iap-test] + 0xa1dcb
 7: (0xb4023589) [/usr/lib/libcapi-appfw-application.so.0] + 0x2589
 8: appcore_efl_main + 0x43a (0xb6f75d3f) [/usr/lib/libappcore-efl.so.1] + 0x3d3f
 9: ui_app_main + 0xc0 (0xb4023909) [/usr/lib/libcapi-appfw-application.so.0] + 0x2909
10: cocos2d::Application::run() + 0x60 (0xb24a2e45) [/opt/usr/apps/org.example.iap-test/bin/iap-test] + 0xa1e45
11: main + 0x32 (0xb2435e23) [/opt/usr/apps/org.example.iap-test/bin/iap-test] + 0x34e23
12: (0xb6ff0ccf) [/opt/usr/apps/org.example.iap-test/bin/iap-test] + 0x1ccf
13: __libc_start_main + 0x114 (0xb670f4bc) [/lib/libc.so.6] + 0x164bc
14: (0xb6ff1114) [/opt/usr/apps/org.example.iap-test/bin/iap-test] + 0x2114
End of Call Stack

Package Information
Package Name: org.example.iap-test
Package ID : org.example.iap-test
Version: 1.0.0
Package Type: tpk
App Name: iap-test
App ID: org.example.iap-test
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
473) > Recent apps: (nil) (0)
11-23 14:03:40.910+0530 D/TASK_MGR_LITE(18060): recent_app_viewer.c: create_close_all_btn(1424) > Create close all button
11-23 14:03:40.910+0530 E/EFL     (  351): evas-gl_x11<351> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
11-23 14:03:40.920+0530 E/EFL     (  351): evas-gl_x11<351> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
11-23 14:03:40.950+0530 D/UXT     (18060): uxt_theme_private.c: uxt_theme_replace_color(1101) > new code for edje(8000ec77) [rgb: 0,0,0,43] [rgb2: 255,255,255,255] [rgb3: 255,255,255,255]
11-23 14:03:40.950+0530 D/UXT     (18060): uxt_theme_private.c: uxt_theme_replace_color(1106) > color code replace: [W012 -> AO001], W012: [rgb: 0,0,0,43] [rgb2: 255,255,255,255] [rgb3: 255,255,255,255]
11-23 14:03:40.950+0530 D/UXT     (18060): uxt_theme_private.c: uxt_theme_replace_color(1101) > new code for edje(8000ec77) [rgb: 0,0,0,140] [rgb2: 255,255,255,255] [rgb3: 255,255,255,255]
11-23 14:03:40.950+0530 D/UXT     (18060): uxt_theme_private.c: uxt_theme_replace_color(1106) > color code replace: [B043 -> AO001P], B043: [rgb: 0,0,0,140] [rgb2: 255,255,255,255] [rgb3: 255,255,255,255]
11-23 14:03:40.950+0530 D/UXT     (18060): uxt_theme_private.c: uxt_theme_replace_color(1101) > new code for edje(8000ec77) [rgb: 0,0,0,25] [rgb2: 255,255,255,255] [rgb3: 255,255,255,255]
11-23 14:03:40.950+0530 D/UXT     (18060): uxt_theme_private.c: uxt_theme_replace_color(1106) > color code replace: [W012D -> AO001D], W012D: [rgb: 0,0,0,25] [rgb2: 255,255,255,255] [rgb3: 255,255,255,255]
11-23 14:03:40.970+0530 D/TASK_MGR_LITE(18060): recent_app_viewer.c: create_recent_app_item(1051) > add app: iap-test
11-23 14:03:40.980+0530 D/LAUNCH  (18060): appcore-efl.c: __before_loop(1162) > [task-mgr:Application:create:done]
11-23 14:03:40.980+0530 D/APP_CORE(18060): appcore-efl.c: __check_wm_rotation_support(841) > Disable window manager rotation
11-23 14:03:40.980+0530 D/APP_CORE(18060): appcore.c: __aul_handler(581) > [APP 18060]     AUL event: AUL_START
11-23 14:03:40.980+0530 I/APP_CORE(18060): appcore-efl.c: __do_app(514) > [APP 18060] Event: RESET State: CREATED
11-23 14:03:40.980+0530 D/APP_CORE(18060): appcore-efl.c: __do_app(545) > [APP 18060] RESET
11-23 14:03:40.980+0530 D/LAUNCH  (18060): appcore-efl.c: __do_app(547) > [task-mgr:Application:reset:start]
11-23 14:03:40.980+0530 D/APP_CORE(18060): appcore-efl.c: __do_app(550) > [__SUSPEND__] reset case
11-23 14:03:40.980+0530 D/APP_CORE(18060): appcore-efl.c: __appcore_efl_exit_from_suspend(379) > [__SUSPEND__]
11-23 14:03:40.980+0530 I/CAPI_APPFW_APPLICATION(18060): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
11-23 14:03:40.980+0530 D/LAUNCH  (18060): appcore-efl.c: __do_app(560) > [task-mgr:Application:reset:done]
11-23 14:03:40.980+0530 D/APP_CORE(18060): appcore.c: __aul_handler(602) > [SECURE_LOG] caller_appid : (null)
11-23 14:03:40.980+0530 E/EFL     (18060): edje<18060> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
11-23 14:03:40.980+0530 E/EFL     (18060): By the power of Grayskull, your previous Embryo stack is now broken!
11-23 14:03:40.980+0530 E/EFL     (18060): edje<18060> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
11-23 14:03:40.980+0530 E/EFL     (18060): By the power of Grayskull, your previous Embryo stack is now broken!
11-23 14:03:40.990+0530 W/APP_CORE(18060): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:6000003
11-23 14:03:40.990+0530 D/APP_CORE(18060): appcore-efl.c: __add_win(759) > [EVENT_TEST][EVENT] __add_win WIN:6000003
11-23 14:03:40.990+0530 D/APP_CORE(18060): appcore-group.c: appcore_group_attach(13) > appcore_group_attach
11-23 14:03:40.990+0530 D/AUL     (18060): app_sock.c: __app_send_raw(288) > pid(-2) : cmd(35)
11-23 14:03:40.990+0530 W/AUL_AMD (  608): amd_request.c: __request_handler(906) > __request_handler: 35
11-23 14:03:41.100+0530 D/TASK_MGR_LITE(18060): recent_app_viewer.c: on_scroll_to_cb(1169) > on_scroll_to_cb
11-23 14:03:41.100+0530 D/TASK_MGR_LITE(18060): recent_app_viewer.c: on_scroll_to_cb(1185) > v_page: 6
11-23 14:03:41.100+0530 D/TASK_MGR_LITE(18060): recent_app_viewer.c: on_scroller_move(999) > on_scroller_move
11-23 14:03:41.100+0530 D/TASK_MGR_LITE(18060): recent_app_viewer.c: update_capture_animation(382) > update_capture_animation
11-23 14:03:41.100+0530 D/TASK_MGR_LITE(18060): recent_app_viewer.c: find_capture_app(184) > v_page: 6
11-23 14:03:41.100+0530 D/TASK_MGR_LITE(18060): recent_app_viewer.c: find_capture_app(191) > capture app index: 0
11-23 14:03:41.100+0530 D/UXT     (  351): uxt_theme.c: uxt_theme_delete_color_table(654) > color table (b895ca78) is freed
11-23 14:03:41.110+0530 W/AUL_AMD (  608): amd_launch.c: __e17_status_handler(3328) > pid(18060) status(0)
11-23 14:03:41.110+0530 D/AUL_AMD (  608): amd_launch.c: __send_cpu_boost(538) > __send_cpu_boost enter
11-23 14:03:41.110+0530 D/AUL_AMD (  608): amd_launch.c: __send_cpu_boost(563) > __send_cpu_boost ok
11-23 14:03:41.110+0530 D/LAUNCH  (  608): amd_launch.c: __e17_status_handler(3384) > [task-mgr:Application:Launching:done]
11-23 14:03:41.110+0530 D/APP_CORE(18151): appcore-efl.c: __update_win(805) > [EVENT_TEST][EVENT] __update_win WIN:2000003 fully_obscured 1
11-23 14:03:41.110+0530 D/APP_CORE(18151): appcore-efl.c: __visibility_cb(980) > bvisibility 0, b_active 1
11-23 14:03:41.110+0530 D/APP_CORE(18151): appcore-efl.c: __visibility_cb(995) >  Go to Pasue state 
11-23 14:03:41.110+0530 I/APP_CORE(18151): appcore-efl.c: __do_app(514) > [APP 18151] Event: PAUSE State: RUNNING
11-23 14:03:41.110+0530 D/APP_CORE(18151): appcore-efl.c: __do_app(581) > [APP 18151] PAUSE
11-23 14:03:41.110+0530 I/CAPI_APPFW_APPLICATION(18151): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
11-23 14:03:41.110+0530 D/APP_CORE(18151): appcore-efl.c: __trm_app_info_send_socket(241) > __trm_app_info_send_socket
11-23 14:03:41.110+0530 D/APP_CORE(18151): appcore-efl.c: __trm_app_info_send_socket(268) > send
11-23 14:03:41.120+0530 D/QUICKPANEL( 2094): QuickpanelApp.cpp: __onEcoreEventMsgReceived(925) > [0;34m>>>HIT<<<[0;m
11-23 14:03:41.120+0530 W/AUL_AMD (  608): amd_launch.c: __e17_status_handler(3328) > pid(18060) status(0)
11-23 14:03:41.120+0530 D/AUL_AMD (  608): amd_launch.c: __send_cpu_boost(538) > __send_cpu_boost enter
11-23 14:03:41.120+0530 D/AUL_AMD (  608): amd_launch.c: __send_cpu_boost(563) > __send_cpu_boost ok
11-23 14:03:41.120+0530 D/LAUNCH  (  608): amd_launch.c: __e17_status_handler(3384) > [task-mgr:Application:Launching:done]
11-23 14:03:41.120+0530 D/QUICKPANEL( 2094): QuickpanelApp.cpp: __onEcoreEventMsgReceived(925) > [0;34m>>>HIT<<<[0;m
11-23 14:03:41.120+0530 W/AUL_AMD (  608): amd_launch.c: __e17_status_handler(3328) > pid(18151) status(4)
11-23 14:03:41.120+0530 D/AUL_AMD (  608): amd_status.c: _status_update_app_info_list(431) > pid(18151) status(4)
11-23 14:03:41.120+0530 D/AUL_AMD (  608): amd_status.c: _status_update_app_info_list(442) > pid(18151) appid(org.example.iap-test) pkgid(org.example.iap-test) status(4)
11-23 14:03:41.120+0530 W/AUL     (  608): amd_app_group.c: __set_fg_flag(190) > send_signal BG org.example.iap-test(18151)
11-23 14:03:41.120+0530 W/AUL     (  608): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 18151, appid: org.example.iap-test, status: bg
11-23 14:03:41.120+0530 W/AUL_AMD (  608): amd_launch.c: __e17_status_handler(3328) > pid(18060) status(3)
11-23 14:03:41.120+0530 D/APP_CORE(18060): appcore.c: __prt_ltime(235) > [APP 18060] first idle after reset: 608 msec
11-23 14:03:41.120+0530 D/AUL_AMD (  608): amd_key.c: _key_ungrab(265) > _key_ungrab, win : e00002
11-23 14:03:41.120+0530 W/AUL_AMD (  608): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
11-23 14:03:41.120+0530 W/AUL_AMD (  608): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
11-23 14:03:41.120+0530 D/AUL_AMD (  608): amd_launch.c: __send_cpu_boost(538) > __send_cpu_boost enter
11-23 14:03:41.120+0530 D/AUL_AMD (  608): amd_launch.c: __send_cpu_boost(563) > __send_cpu_boost ok
11-23 14:03:41.120+0530 D/AUL_AMD (  608): amd_status.c: _status_update_app_info_list(431) > pid(18060) status(3)
11-23 14:03:41.120+0530 D/AUL_AMD (  608): amd_status.c: _status_update_app_info_list(442) > pid(18060) appid(com.samsung.task-mgr) pkgid(com.samsung.task-mgr) status(3)
11-23 14:03:41.120+0530 W/AUL     (  608): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.task-mgr(18060)
11-23 14:03:41.120+0530 W/AUL     (  608): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 18060, appid: com.samsung.task-mgr, status: fg
11-23 14:03:41.120+0530 I/samsung-log-manager( 1449): SLogMgr_UseAppStatusMonitor.cpp: DbusSignalHandlerAppFw(233) > [SECURE_LOG] [(233)]: Background 18151 org.example.iap-test
11-23 14:03:41.120+0530 E/samsung-log-manager( 1449): SLogMgr_UseAppStatusMonitor.cpp: InsertLog(316) > [SECURE_LOG]  [(316)]: Invalid duration 1448267621133
11-23 14:03:41.120+0530 I/samsung-log-manager( 1449): SLogMgr_UseAppStatusMonitor.cpp: DbusSignalHandlerAppFw(237) > [SECURE_LOG] [(237)]: Failed to insert log to use app survey table
11-23 14:03:41.120+0530 D/APP_CORE(18060): appcore-efl.c: __update_win(805) > [EVENT_TEST][EVENT] __update_win WIN:6000003 fully_obscured 0
11-23 14:03:41.120+0530 D/APP_CORE(18060): appcore-efl.c: __visibility_cb(980) > bvisibility 1, b_active -1
11-23 14:03:41.120+0530 D/APP_CORE(18060): appcore-efl.c: __visibility_cb(983) >  Go to Resume state
11-23 14:03:41.120+0530 I/APP_CORE(18060): appcore-efl.c: __do_app(514) > [APP 18060] Event: RESUME State: CREATED
11-23 14:03:41.120+0530 D/LAUNCH  (18060): appcore-efl.c: __do_app(610) > [task-mgr:Application:resume:start]
11-23 14:03:41.120+0530 D/APP_CORE(18060): appcore-efl.c: __do_app(613) > [__SUSPEND__] resume case
11-23 14:03:41.120+0530 D/APP_CORE(18060): appcore-efl.c: __appcore_efl_exit_from_suspend(379) > [__SUSPEND__]
11-23 14:03:41.120+0530 D/APP_CORE(18060): appcore-efl.c: __do_app(618) > [APP 18060] RESUME
11-23 14:03:41.130+0530 D/RESOURCED(  667): heart-cpu.c: heart_cpu_write_data(168) > heart_cpu_write_data : pid = 18151, appname = org.example.iap-test, pkgname = org.example.iap-test, type=2
11-23 14:03:41.130+0530 D/RESOURCED(  667): cgroup.c: cgroup_read_node(153) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/net_cls/org.example.iap-test/net_cls.classid, value 291
11-23 14:03:41.130+0530 D/RESOURCED(  667): cpu.c: cpu_background_state(275) > cpu_background_state : pid = 18151, appname = org.example.iap-test
11-23 14:03:41.130+0530 D/RESOURCED(  667): cgroup.c: cgroup_write_node(133) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/background/cgroup.procs, value 18151
11-23 14:03:41.130+0530 D/RESOURCED(  667): proc-process.c: proc_backgrd_manage(191) > BACKGRD : process 10742 set score 540 (before 510)
11-23 14:03:41.130+0530 D/RESOURCED(  667): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1693) > pid: 18151, proc_name: org.example.iap-test, cg_name: previous, oom_score_adj: 300
11-23 14:03:41.130+0530 D/RESOURCED(  667): cgroup.c: cgroup_write_node(133) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/previous//cgroup.procs, value 18151
11-23 14:03:41.130+0530 E/EFL     (  351): evas-gl_x11<351> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
11-23 14:03:41.130+0530 D/PKGMGR_INFO( 1449): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_add_string(3467) > [SECURE_LOG] First value is 'http://tizen.org/category/lockapp'
11-23 14:03:41.140+0530 D/PKGMGR_INFO( 1449): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_count(3547) > [SECURE_LOG] where = package_app_app_category.category IN ('http://tizen.org/category/lockapp') and package_app_info.app_id='com.samsung.task-mgr' and package_app_info.app_disable IN ('false','False')
11-23 14:03:41.140+0530 D/PKGMGR_INFO( 1449): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_count(3553) > [SECURE_LOG] query = select DISTINCT package_app_info.app_id, package_app_info.app_component, package_app_info.app_installed_storage from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale='en-gb' LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_app_category.category IN ('http://tizen.org/category/lockapp') and package_app_info.app_id='com.samsung.task-mgr' and package_app_info.app_disable IN ('false','False')
11-23 14:03:41.140+0530 D/PKGMGR_INFO( 1449): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_add_string(3467) > [SECURE_LOG] First value is 'http://tizen.org/category/homeapp'
11-23 14:03:41.140+0530 D/PKGMGR_INFO( 1449): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_count(3547) > [SECURE_LOG] where = package_app_app_category.category IN ('http://tizen.org/category/homeapp') and package_app_info.app_id='com.samsung.task-mgr' and package_app_info.app_disable IN ('false','False')
11-23 14:03:41.140+0530 D/PKGMGR_INFO( 1449): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_count(3553) > [SECURE_LOG] query = select DISTINCT package_app_info.app_id, package_app_info.app_component, package_app_info.app_installed_storage from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale='en-gb' LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_app_category.category IN ('http://tizen.org/category/homeapp') and package_app_info.app_id='com.samsung.task-mgr' and package_app_info.app_disable IN ('false','False')
11-23 14:03:41.140+0530 I/TIZEN_N_EFL_UTIL_WINDOW(18151): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 29
11-23 14:03:41.140+0530 E/APP_CORE(18151): appcore-efl.c: _capture_and_make_file(1619) > win[2000003] widget[720] height[1280]
11-23 14:03:41.140+0530 D/AUL     (18151): app_sock.c: __app_send_raw(288) > pid(-2) : cmd(33)
11-23 14:03:41.140+0530 W/AUL_AMD (  608): amd_request.c: __request_handler(906) > __request_handler: 33
11-23 14:03:41.150+0530 D/AUL     (18151): pkginfo.c: aul_app_get_appid_bypid(238) > [SECURE_LOG] appid for 18151 is org.example.iap-test
11-23 14:03:41.150+0530 I/APP_CORE(18060): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
11-23 14:03:41.150+0530 I/APP_CORE(18060): appcore-efl.c: __do_app(625) > [APP 18060] Initial Launching, call the resume_cb
11-23 14:03:41.150+0530 I/CAPI_APPFW_APPLICATION(18060): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
11-23 14:03:41.150+0530 D/LAUNCH  (18060): appcore-efl.c: __do_app(647) > [task-mgr:Application:resume:done]
11-23 14:03:41.150+0530 D/APP_CORE(18060): appcore-efl.c: __trm_app_info_send_socket(241) > __trm_app_info_send_socket
11-23 14:03:41.150+0530 D/APP_CORE(18060): appcore-efl.c: __trm_app_info_send_socket(268) > send
11-23 14:03:41.150+0530 I/samsung-log-manager( 1449): SLogMgr_UseAppStatusMonitor.cpp: DbusSignalHandlerAppFw(218) > [SECURE_LOG] [(218)]: Foreground 18060 com.samsung.task-mgr
11-23 14:03:41.180+0530 D/STARTER ( 2004): hw_key.c: _key_release_cb(552) > [_key_release_cb:552] _key_release_cb : XF86Home Released
11-23 14:03:41.180+0530 W/STARTER ( 2004): hw_key.c: _key_release_cb(580) > [_key_release_cb:580] Home Key is released
11-23 14:03:41.180+0530 D/STARTER ( 2004): lock-daemon-lite.c: lockd_get_hall_status(360) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.53/src/lock-daemon-lite.c:360:D] [ == lockd_get_hall_status == ]
11-23 14:03:41.180+0530 E/EFL     ( 2084): ecore_x<2084> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=93039640
11-23 14:03:41.180+0530 E/EFL     ( 2084): evas_events.c: _evas_canvas_event_feed_key_up_with_keycode(3010) > [SECURE_LOG] Evas KeyEvent:release time=93039640 keyname = XF86Home key = XF86Home keycode = 147
11-23 14:03:41.190+0530 E/STARTER ( 2004): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(340) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.53/src/lock-daemon-lite.c:340:E] dbus_connection_send error(No reply)
11-23 14:03:41.190+0530 E/STARTER ( 2004): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(344) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.53/src/lock-daemon-lite.c:344:E] dbus_connection_send error(org.freedesktop.DBus.Error.UnknownMethod:Method "getstatus" with signature "" on interface "org.tizen.system.deviced.hall" doesn't exist
11-23 14:03:41.190+0530 E/STARTER ( 2004): )
11-23 14:03:41.190+0530 D/STARTER ( 2004): hw_key.c: _key_release_cb(618) > [_key_release_cb:618] delete cancelkey timer
11-23 14:03:41.190+0530 I/SYSPOPUP( 2093): syspopup.c: __X_syspopup_term_handler(98) > enter syspopup term handler
11-23 14:03:41.190+0530 I/SYSPOPUP( 2093): syspopup.c: __X_syspopup_term_handler(108) > term action 1 - volume
11-23 14:03:41.190+0530 D/VOLUME  ( 2093): volume_control.c: volume_control_close(828) > [volume_control_close:828] Start closing volume
11-23 14:03:41.190+0530 E/VOLUME  ( 2093): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
11-23 14:03:41.190+0530 E/VOLUME  ( 2093): volume_control.c: volume_control_close(841) > [volume_control_close:841] Failed to unregister x input event handler
11-23 14:03:41.190+0530 D/VOLUME  ( 2093): volume_key_event.c: volume_key_event_key_ungrab(179) > [volume_key_event_key_ungrab:179] key ungrabed
11-23 14:03:41.190+0530 D/VOLUME  ( 2093): volume_control.c: volume_control_close(853) > [volume_control_close:853] ungrab key : 1/1
11-23 14:03:41.190+0530 D/VOLUME  ( 2093): volume_key_event.c: volume_key_event_key_grab(128) > [volume_key_event_key_grab:128] count_grabed : 1
11-23 14:03:41.190+0530 D/VOLUME  ( 2093): volume_control.c: volume_control_close(875) > [volume_control_close:875] End closing volume
11-23 14:03:41.200+0530 D/RESOURCED(  667): counter-process.c: _process_network_counter(1156) > There is no serialized counters in response
11-23 14:03:41.200+0530 D/RESOURCED(  667): proc-main.c: resourced_proc_status_change(877) > [SECURE_LOG] set foreground : 18060
11-23 14:03:41.200+0530 D/RESOURCED(  667): counter-process.c: _process_network_counter(1156) > There is no serialized counters in response
11-23 14:03:41.200+0530 D/RESOURCED(  667): counter-process.c: _process_network_counter(1156) > There is no serialized counters in response
11-23 14:03:41.200+0530 D/RESOURCED(  667): counter-process.c: _process_network_counter(1156) > There is no serialized counters in response
11-23 14:03:41.200+0530 D/RESOURCED(  667): counter-process.c: _process_network_counter(1156) > There is no serialized counters in response
11-23 14:03:41.210+0530 D/RESOURCED(  667): counter-process.c: _process_network_counter(1156) > There is no serialized counters in response
11-23 14:03:41.210+0530 D/RESOURCED(  667): counter-process.c: _process_network_counter(1156) > There is no serialized counters in response
11-23 14:03:41.210+0530 D/RESOURCED(  667): counter-process.c: _process_network_counter(1156) > There is no serialized counters in response
11-23 14:03:41.300+0530 D/TASK_MGR_LITE(18060): capture_inotify.c: on_fd_inotify_cb(19) > on_fd_inotify_cb
11-23 14:03:41.300+0530 D/TASK_MGR_LITE(18060): capture_inotify.c: on_fd_inotify_cb(87) > A jpeg file (org.example.iap-test.jpg) is added or modified now
11-23 14:03:41.300+0530 D/TASK_MGR_LITE(18060): recent_app_viewer.c: update_app_capture(1640) > update capture file: /opt/usr/share/app_capture/org.example.iap-test.jpg
11-23 14:03:41.310+0530 E/EFL     (18151): ecore_x<18151> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=93039640
11-23 14:03:41.310+0530 E/EFL     (18151): evas_events.c: _evas_canvas_event_feed_key_up_with_keycode(3010) > [SECURE_LOG] Evas KeyEvent:release time=93039640 keyname = XF86Home key = XF86Home keycode = 147
11-23 14:03:41.690+0530 D/AUL_PAD ( 1390): launchpad.c: __send_launchpad_loader(439) > Prepare another candidate process
11-23 14:03:41.700+0530 D/AUL_PAD (18604): sigchild.h: __signal_unblock_sigchld(225) > SIGCHLD unblocked
11-23 14:03:41.710+0530 D/AUL_PAD ( 1390): sigchild.h: __send_app_launch_signal(132) > send launch signal done
11-23 14:03:41.720+0530 D/PKGMGR_INFO( 1185): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3662) > [SECURE_LOG] where = package_app_info.app_exec='/usr/apps/com.samsung.task-mgr/bin/task-mgr' and package_app_info.app_disable IN ('false','False')
11-23 14:03:41.720+0530 D/PKGMGR_INFO( 1185): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3668) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-gb') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/apps/com.samsung.task-mgr/bin/task-mgr' and package_app_info.app_disable IN ('false','False')
11-23 14:03:41.730+0530 E/RESOURCED(  667): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1758
11-23 14:03:41.740+0530 D/AUL     ( 1185): pkginfo.c: aul_app_get_appid_bypid(238) > [SECURE_LOG] appid for 18060 is com.samsung.task-mgr
11-23 14:03:41.740+0530 I/Tizen::App( 1185): (499) > LaunchedApp(com.samsung.task-mgr)
11-23 14:03:41.740+0530 I/Tizen::App( 1185): (733) > Finished invoking application event listener for com.samsung.task-mgr, 18060.
11-23 14:03:41.860+0530 D/AUL_PAD (18604): launchpad_loader.c: main(584) > [candidate] Another candidate process was forked.
11-23 14:03:41.860+0530 D/AUL_PAD (18604): preload.h: __preload_init(52) > max_cmdline_size = 1053
11-23 14:03:41.891+0530 D/AUL_PAD (18604): preload.h: __preload_init(65) > preload /usr/lib/libappcore-efl.so.1# - handle : b70b2d00
11-23 14:03:41.891+0530 D/AUL_PAD (18604): preload.h: __preload_init(69) > get pre-initialization function
11-23 14:03:41.891+0530 D/AUL_PAD (18604): preload.h: __preload_init(73) > get shutdown function
11-23 14:03:41.891+0530 D/AUL_PAD (18604): preload.h: __preload_init(65) > preload /usr/lib/libappcore-common.so.1# - handle : b70a83f0
11-23 14:03:41.901+0530 D/AUL_PAD (18604): preload.h: __preload_init(65) > preload /usr/lib/libcapi-appfw-application.so.0# - handle : b70aa640
11-23 14:03:41.901+0530 D/AUL_PAD (18604): preload.h: __preload_init(69) > get pre-initialization function
11-23 14:03:41.901+0530 D/AUL_PAD (18604): preload.h: __preload_init(73) > get shutdown function
11-23 14:03:41.911+0530 D/AUL_PAD (18604): process_pool_preload.h: __preload_init_for_process_pool(100) > preload /usr/lib/libboost_thread.so.1.51.0 - handle : b70ab7f0
11-23 14:03:42.071+0530 D/AUL_PAD (18604): process_pool_preload.h: __preload_init_for_process_pool(100) > preload /usr/lib/libdali-toolkit.so - handle : b70ac5f8
11-23 14:03:42.081+0530 D/AUL_PAD (18604): process_pool_preload.h: __preload_init_for_process_pool(100) > preload /usr/lib/libcairo.so - handle : b4617000
11-23 14:03:42.091+0530 D/AUL_PAD (18604): process_pool_preload.h: __preload_init_for_process_pool(100) > preload /usr/lib/libefl-assist.so.0 - handle : b70bf2c8
11-23 14:03:42.131+0530 D/AUL_PAD (18604): process_pool_preload.h: __preload_init_for_process_pool(100) > preload /usr/lib/libprotobuf.so - handle : b70bf960
11-23 14:03:42.171+0530 D/AUL_PAD (18604): process_pool_preload.h: __preload_init_for_process_pool(100) > preload /usr/lib/libcapi-media-player.so.0 - handle : b70c1150
11-23 14:03:42.191+0530 D/AUL_PAD (18604): process_pool_preload.h: __preload_init_for_process_pool(100) > preload /usr/lib/libcapi-media-camera.so.0 - handle : b70c3d48
11-23 14:03:42.191+0530 D/AUL_PAD (18604): preexec.h: __preexec_init(76) > preexec start
11-23 14:03:42.191+0530 D/AUL_PAD (18604): preexec.h: __preexec_init(106) > preexec tpk /usr/lib/libosp-env-config.so# - handle : b70c0d80
11-23 14:03:42.191+0530 D/AUL     (18604): process_pool.c: __connect_to_launchpad(107) > [launchpad] enter, type: 2
11-23 14:03:42.191+0530 D/AUL     (18604): process_pool.c: __connect_to_launchpad(119) > connect to /tmp/.launchpad-type2
11-23 14:03:42.191+0530 D/AUL     (18604): process_pool.c: __connect_to_launchpad(132) > send(18604) : 4
11-23 14:03:42.191+0530 D/AUL     (18604): process_pool.c: __connect_to_launchpad(139) > [SECURE_LOG] [launchpad] done, connect fd: 9
11-23 14:03:42.191+0530 D/AUL_PAD ( 1390): launchpad.c: main(675) > pfds[LAUNCH_PAD].revent  : 0x0
11-23 14:03:42.191+0530 D/AUL_PAD ( 1390): launchpad.c: main(677) > pfds[POOL_TYPE + 0].revents : 0x0
11-23 14:03:42.191+0530 D/AUL_PAD ( 1390): launchpad.c: main(678) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
11-23 14:03:42.191+0530 D/AUL_PAD ( 1390): launchpad.c: main(677) > pfds[POOL_TYPE + 1].revents : 0x0
11-23 14:03:42.191+0530 D/AUL_PAD ( 1390): launchpad.c: main(678) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
11-23 14:03:42.191+0530 D/AUL_PAD ( 1390): launchpad.c: main(677) > pfds[POOL_TYPE + 2].revents : 0x1
11-23 14:03:42.191+0530 D/AUL_PAD ( 1390): launchpad.c: main(678) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
11-23 14:03:42.191+0530 D/AUL_PAD ( 1390): launchpad.c: main(717) > pfds[POOL_TYPE + 2].revents & POLLIN
11-23 14:03:42.191+0530 D/AUL_PAD ( 1390): launchpad.c: main(729) > [SECURE_LOG] Type 2 candidate process was connected, pid: 18604
11-23 14:03:42.211+0530 D/AUL_AMD (  608): amd_request.c: __add_history_handler(412) > [SECURE_LOG] appid: com.samsung.task-mgr, alias_appid: com.samsung.task-mgr
11-23 14:03:42.211+0530 D/AUL_AMD (  608): amd_request.c: __add_history_handler(434) > [SECURE_LOG] add rua history com.samsung.task-mgr /usr/apps/com.samsung.task-mgr/bin/task-mgr
11-23 14:03:42.211+0530 D/RUA     (  608): rua.c: rua_add_history(179) > rua_add_history start
11-23 14:03:42.221+0530 D/RUA     (  608): rua.c: rua_add_history(247) > rua_add_history ok
11-23 14:03:42.231+0530 E/EFL     (18060): ecore_x<18060> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=93040692
11-23 14:03:42.231+0530 E/EFL     (18060): evas_events.c: _evas_canvas_event_feed_mouse_down(1171) > [SECURE_LOG] ButtonEvent:down time=93040692 x=376 y=1228 button=1 downs=0 grabbed=0
11-23 14:03:42.231+0530 E/EFL     (18060): evas_events.c: _evas_canvas_event_feed_mouse_down(1267) > [SECURE_LOG] ButtonEvent:candidate object count=1
11-23 14:03:42.231+0530 E/EFL     (18060): evas_events.c: _evas_input_debug_info(3412) > [SECURE_LOG] [Press] button:1, [376,1228], obj : 0xb91e40b8, smart : 0x8000ec77, edje, [150,1182,420,78], event:[0,1], time:[93040692]
11-23 14:03:42.231+0530 E/EFL     (18060): evas_events.c: _evas_canvas_event_feed_mouse_down(1306) > [SECURE_LOG] del:0, layer:[0xb9091188,0], 0
11-23 14:03:42.351+0530 E/EFL     (18060): ecore_x<18060> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=93040814
11-23 14:03:42.351+0530 E/EFL     (18060): evas_events.c: _evas_canvas_event_feed_mouse_up(1481) > [SECURE_LOG] ButtonEvent:up time=93040814 x=374 y=1228 button=1 downs=1
11-23 14:03:42.351+0530 E/EFL     (18060): evas_events.c: _evas_input_debug_info(3412) > [SECURE_LOG] [Release] button:1, [374,1228], obj : 0xb91e40b8, smart : 0x8000ec77, edje, [150,1182,420,78], event:[0,1], time:[93040814]
11-23 14:03:42.351+0530 D/TASK_MGR_LITE(18060): recent_app_viewer.c: on_close_all_clicked(1382) > clicked close all applications button
11-23 14:03:42.351+0530 D/TASK_MGR_LITE(18060): recent_app_viewer.c: close_all_animation(1366) > close_all_animation
11-23 14:03:42.351+0530 D/TASK_MGR_LITE(18060): recent_app_viewer.c: close_all_animation_cb(1337) > close_all_animation_cb, pos: 0.002136
11-23 14:03:42.371+0530 D/TASK_MGR_LITE(18060): recent_app_viewer.c: close_all_animation_cb(1337) > close_all_animation_cb, pos: 0.057576
11-23 14:03:42.381+0530 D/TASK_MGR_LITE(18060): recent_app_viewer.c: close_all_animation_cb(1337) > close_all_animation_cb, pos: 0.113016
11-23 14:03:42.401+0530 D/TASK_MGR_LITE(18060): recent_app_viewer.c: close_all_animation_cb(1337) > close_all_animation_cb, pos: 0.168456
11-23 14:03:42.421+0530 D/TASK_MGR_LITE(18060): recent_app_viewer.c: close_all_animation_cb(1337) > close_all_animation_cb, pos: 0.223896
11-23 14:03:42.441+0530 D/TASK_MGR_LITE(18060): recent_app_viewer.c: close_all_animation_cb(1337) > close_all_animation_cb, pos: 0.279439
11-23 14:03:42.451+0530 D/TASK_MGR_LITE(18060): recent_app_viewer.c: close_all_animation_cb(1337) > close_all_animation_cb, pos: 0.334879
11-23 14:03:42.471+0530 D/TASK_MGR_LITE(18060): recent_app_viewer.c: close_all_animation_cb(1337) > close_all_animation_cb, pos: 0.390319
11-23 14:03:42.481+0530 D/TASK_MGR_LITE(18060): recent_app_viewer.c: close_all_animation_cb(1337) > close_all_animation_cb, pos: 0.445759
11-23 14:03:42.501+0530 D/TASK_MGR_LITE(18060): recent_app_viewer.c: close_all_animation_cb(1337) > close_all_animation_cb, pos: 0.501299
11-23 14:03:42.521+0530 D/TASK_MGR_LITE(18060): recent_app_viewer.c: close_all_animation_cb(1337) > close_all_animation_cb, pos: 0.556739
11-23 14:03:42.531+0530 D/UXT     (18604): uxt_theme_private.c: uxt_theme_get_table_number(634) > index: 999, hsv: 230, 92, 74
11-23 14:03:42.531+0530 D/UXT     (18604): uxt_theme_private.c: uxt_theme_get_table_number(656) > input color table for theme index (999): ChangeableColorTable1.xml
11-23 14:03:42.531+0530 D/TASK_MGR_LITE(18060): recent_app_viewer.c: close_all_animation_cb(1337) > close_all_animation_cb, pos: 0.612182
11-23 14:03:42.531+0530 D/UXT     (18604): uxt_theme.c: uxt_theme_add_color_table(620) > color table (b72048d0) from (/usr/share/themes/ChangeableColorTable1.xml) is created
11-23 14:03:42.541+0530 D/UXT     (18604): uxt_theme_private.c: uxt_theme_get_core_color_list(1748) > core base color index : 0 (/usr/share/themes/ChangeableColorTable1.xml)
11-23 14:03:42.541+0530 I/UXT     (18604): Uxt_ObjectManager.cpp: OnInitialized(734) > Initialized.
11-23 14:03:42.551+0530 D/AUL_PAD (18604): launchpad_loader.c: main(620) > [candidate] elm init, returned: 1
11-23 14:03:42.551+0530 D/TASK_MGR_LITE(18060): recent_app_viewer.c: close_all_animation_cb(1337) > close_all_animation_cb, pos: 0.667722
11-23 14:03:42.571+0530 D/TASK_MGR_LITE(18060): recent_app_viewer.c: close_all_animation_cb(1337) > close_all_animation_cb, pos: 0.723162
11-23 14:03:42.581+0530 D/TASK_MGR_LITE(18060): recent_app_viewer.c: close_all_animation_cb(1337) > close_all_animation_cb, pos: 0.778602
11-23 14:03:42.591+0530 E/TBM     (18604): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
11-23 14:03:42.591+0530 I/MALI    (18604): egl_platform_x11.c: __egl_platform_initialize(242) > [EGL-X11] PID=18604   open drm_fd=30 
11-23 14:03:42.601+0530 D/TASK_MGR_LITE(18060): recent_app_viewer.c: close_all_animation_cb(1337) > close_all_animation_cb, pos: 0.834042
11-23 14:03:42.621+0530 D/TASK_MGR_LITE(18060): recent_app_viewer.c: close_all_animation_cb(1337) > close_all_animation_cb, pos: 0.889586
11-23 14:03:42.631+0530 D/TASK_MGR_LITE(18060): recent_app_viewer.c: close_all_animation_cb(1337) > close_all_animation_cb, pos: 0.945026
11-23 14:03:42.651+0530 D/TASK_MGR_LITE(18060): recent_app_viewer.c: close_all_animation_cb(1337) > close_all_animation_cb, pos: 1.000000
11-23 14:03:42.651+0530 D/TASK_MGR_LITE(18060): recent_app_viewer.c: close_all_animation_cb(1355) > Fade out End !! 
11-23 14:03:42.651+0530 D/TASK_MGR_LITE(18060): recent_app_viewer.c: quit_idler_cb(1323) > Quit idler, call elm_exit()
11-23 14:03:42.651+0530 D/TASK_MGR_LITE(18060): recent_app_viewer.c: show_no_app_label(1399) > show_no_app_label
11-23 14:03:42.661+0530 D/AUL     (18060): app_sock.c: __app_send_raw_with_noreply(387) > pid(-2) : cmd(22)
11-23 14:03:42.661+0530 W/AUL_AMD (  608): amd_request.c: __request_handler(906) > __request_handler: 22
11-23 14:03:42.661+0530 W/AUL_AMD (  608): amd_request.c: __request_handler(1201) > app status : 5
11-23 14:03:42.661+0530 D/AUL_AMD (  608): amd_status.c: _status_update_app_info_list(431) > pid(18060) status(5)
11-23 14:03:42.661+0530 D/AUL_AMD (  608): amd_status.c: _status_update_app_info_list(442) > pid(18060) appid(com.samsung.task-mgr) pkgid(com.samsung.task-mgr) status(5)
11-23 14:03:42.661+0530 W/AUL     (  608): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.task-mgr(18060)
11-23 14:03:42.661+0530 W/AUL     (  608): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 18060, appid: com.samsung.task-mgr, status: bg
11-23 14:03:42.661+0530 D/APP_CORE(18060): appcore-efl.c: __check_skip(707) > ret(0), win(6000003), state(0), num(0)
11-23 14:03:42.661+0530 D/APP_CORE(18060): appcore-efl.c: __after_loop(1177) > [APP 18060] PAUSE before termination
11-23 14:03:42.661+0530 I/CAPI_APPFW_APPLICATION(18060): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
11-23 14:03:42.661+0530 D/TASK_MGR_LITE(18060): task-mgr-lite.c: _pause_app(398) > _pause_app
11-23 14:03:42.661+0530 W/TASK_MGR_LITE(18060): task-mgr-lite.c: _pause_app(403) > 
11-23 14:03:42.661+0530 I/CAPI_APPFW_APPLICATION(18060): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
11-23 14:03:42.661+0530 D/TASK_MGR_LITE(18060): task-mgr-lite.c: _terminate_app(348) > _terminate_app
11-23 14:03:42.661+0530 D/TASK_MGR_LITE(18060): task-mgr-lite.c: task_mgr_close_all(106) > task_mgr_close_all
11-23 14:03:42.661+0530 D/TASK_MGR_LITE(18060): recent_apps.c: recent_apps_kill_selected(182) > kill app, appid: org.example.iap-test
11-23 14:03:42.661+0530 D/TASK_MGR_LITE(18060): recent_apps.c: recent_apps_kill_selected(185) > kill app, pid: 18151
11-23 14:03:42.661+0530 D/AUL     (18060): app_sock.c: __app_send_raw(288) > pid(-2) : cmd(14)
11-23 14:03:42.661+0530 W/AUL_AMD (  608): amd_request.c: __request_handler(906) > __request_handler: 14
11-23 14:03:42.661+0530 D/AUL_AMD (  608): amd_status.c: _status_app_is_running_from_cache(824) > is_running hit cache, return immediately
11-23 14:03:42.661+0530 D/AUL_AMD (  608): amd_request.c: __request_handler(1173) > [SECURE_LOG] APP_IS_RUNNING : org.example.iap-test : 18151
11-23 14:03:42.661+0530 W/AUL_AMD (  608): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 18151
11-23 14:03:42.661+0530 W/AUL     (18060): launch.c: app_request_to_launchpad(396) > request cmd(4) to(18151)
11-23 14:03:42.661+0530 D/AUL     (18060): app_sock.c: __app_send_raw(288) > pid(-2) : cmd(4)
11-23 14:03:42.661+0530 W/AUL_AMD (  608): amd_request.c: __request_handler(906) > __request_handler: 4
11-23 14:03:42.661+0530 I/samsung-log-manager( 1449): SLogMgr_UseAppStatusMonitor.cpp: DbusSignalHandlerAppFw(233) > [SECURE_LOG] [(233)]: Background 18060 com.samsung.task-mgr
11-23 14:03:42.661+0530 I/samsung-log-manager( 1449): SLogMgr_NativeDbHelper.cpp: ExecQuery(180) > [SECURE_LOG] [(180)]: query tmp [INSERT INTO use_app_survey(app_id,duration,timestamp,time_zone) VALUES ('com.samsung.task-mgr',1512,1448267622670,'Asia/Kolkata');]
11-23 14:03:42.661+0530 D/AUL_AMD (  608): amd_request.c: __app_process_by_pid(308) > [SECURE_LOG] __app_process_by_pid, pid: 18151, 
11-23 14:03:42.661+0530 D/AUL     (  608): app_sock.c: __app_send_raw_with_delay_reply(458) > pid(18151) : cmd(4)
11-23 14:03:42.661+0530 D/AUL_AMD (  608): amd_launch.c: _term_app(1237) > term done
11-23 14:03:42.661+0530 D/AUL_AMD (  608): amd_launch.c: __set_reply_handler(1186) > listen fd : 42, send fd : 41
11-23 14:03:42.661+0530 D/APP_CORE(18151): appcore.c: __aul_handler(626) > [APP 18151]     AUL event: AUL_TERMINATE
11-23 14:03:42.661+0530 I/APP_CORE(18151): appcore-efl.c: __do_app(514) > [APP 18151] Event: TERMINATE State: PAUSED
11-23 14:03:42.661+0530 D/APP_CORE(18151): appcore-efl.c: __do_app(535) > [APP 18151] TERMINATE
11-23 14:03:42.661+0530 D/AUL     (18151): app_sock.c: __app_send_raw_with_noreply(387) > pid(-2) : cmd(22)
11-23 14:03:42.661+0530 D/RESOURCED(  667): cgroup.c: cgroup_write_node(133) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 18151
11-23 14:03:42.661+0530 W/AUL_AMD (  608): amd_launch.c: __reply_handler(1083) > listen fd(42) , send fd(41), pid(18151), cmd(4)
11-23 14:03:42.661+0530 W/AUL     (18060): launch.c: app_request_to_launchpad(425) > request cmd(4) result(0)
11-23 14:03:42.661+0530 D/TASK_MGR_LITE(18060): recent_apps.c: kill_pid(93) > terminate pid = 18151
11-23 14:03:42.661+0530 D/RESOURCED(  667): net-cls-cgroup.c: place_pids_to_net_cgroup(330) > /proc/18151/task/18151/children of org.example.iap-test is not existed
11-23 14:03:42.661+0530 D/RESOURCED(  667): cgroup.c: cgroup_write_node(133) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/net_cls/org.example.iap-test/cgroup.procs, value 18151
11-23 14:03:42.661+0530 D/RUA     (18060): rua.c: rua_delete_history_with_pkgname(91) > rua_delete_history_with_pkgname start
11-23 14:03:42.661+0530 D/RESOURCED(  667): freezer-process.c: freezer_process_pid_set(156) > freezer_process_pid_set 18151
11-23 14:03:42.661+0530 W/AUL_AMD (  608): amd_request.c: __request_handler(906) > __request_handler: 22
11-23 14:03:42.661+0530 W/AUL_AMD (  608): amd_request.c: __request_handler(1201) > app status : 5
11-23 14:03:42.661+0530 D/AUL_AMD (  608): amd_status.c: _status_update_app_info_list(431) > pid(18151) status(5)
11-23 14:03:42.661+0530 D/AUL     (18151): app_sock.c: __app_send_raw_with_noreply(387) > pid(-2) : cmd(22)
11-23 14:03:42.661+0530 D/AUL_AMD (  608): amd_status.c: _status_update_app_info_list(442) > pid(18151) appid(org.example.iap-test) pkgid(org.example.iap-test) status(5)
11-23 14:03:42.661+0530 W/AUL_AMD (  608): amd_request.c: __request_handler(906) > __request_handler: 22
11-23 14:03:42.661+0530 W/AUL_AMD (  608): amd_request.c: __request_handler(1201) > app status : 5
11-23 14:03:42.661+0530 D/AUL_AMD (  608): amd_status.c: _status_update_app_info_list(431) > pid(18151) status(5)
11-23 14:03:42.661+0530 D/AUL_AMD (  608): amd_status.c: _status_update_app_info_list(442) > pid(18151) appid(org.example.iap-test) pkgid(org.example.iap-test) status(5)
11-23 14:03:42.671+0530 D/APP_CORE(18151): appcore-efl.c: __check_skip(707) > ret(1), win(2000003), state(b81f1558), num(1)
11-23 14:03:42.671+0530 D/APP_CORE(18151): appcore-efl.c: __check_skip(710) > state[0] : 9
11-23 14:03:42.681+0530 D/RUA     (18060): rua.c: rua_delete_history_with_pkgname(124) > rua_delete_history_with_pkgname ok
11-23 14:03:42.681+0530 D/TASK_MGR_LITE(18060): recent_apps.c: recent_apps_kill_selected(199) > End recent_apps_kill_selected, result: 
11-23 14:03:42.681+0530 D/TASK_MGR_LITE(18060): capture_inotify.c: destroy_capture_inotify(148) > finish inotify of /opt/usr/share/app_capture
11-23 14:03:42.681+0530 E/TASK_MGR_LITE(18060): recent_app_viewer.c: destroy_recent_app_viewer(1583) > destroy_recent_app_viewer
11-23 14:03:42.681+0530 I/TIZEN_N_EFL_UTIL_WINDOW(18151): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 12
11-23 14:03:42.681+0530 E/APP_CORE(18151): appcore-efl.c: _capture_and_make_file(1619) > win[2000003] widget[720] height[1280]
11-23 14:03:42.681+0530 D/AUL     (18151): app_sock.c: __app_send_raw(288) > pid(-2) : cmd(33)
11-23 14:03:42.681+0530 W/AUL_AMD (  608): amd_request.c: __request_handler(906) > __request_handler: 33
11-23 14:03:42.681+0530 E/APP_CORE(18151): appcore-efl.c: _capture_and_make_file(1622) > cannot a capture file for the package of [org.example.iap-test]
11-23 14:03:42.681+0530 I/CAPI_APPFW_APPLICATION(18151): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
11-23 14:03:42.691+0530 D/TASK_MGR_LITE(18060): recent_apps.c: recent_app_list_destroy(635) > recent_app_list_destroy
11-23 14:03:42.691+0530 D/TASK_MGR_LITE(18060): recent_apps.c: list_destroy(374) > START list_destroy
11-23 14:03:42.691+0530 E/TASK_MGR_LITE(18060): recent_apps.c: list_destroy(376) > (NULL == list) -> list_destroy() return
11-23 14:03:42.691+0530 D/TASK_MGR_LITE(18060): recent_apps.c: list_destroy(374) > START list_destroy
11-23 14:03:42.691+0530 D/TASK_MGR_LITE(18060): recent_apps.c: list_destroy(383) > Free: org.example.iap-test
11-23 14:03:42.691+0530 D/TASK_MGR_LITE(18060): recent_apps.c: list_unretrieve_item(215) > Unretrieve app: iap-test (org.example.iap-test)
11-23 14:03:42.701+0530 E/APP_CORE(18060): appcore.c: appcore_flush_memory(793) > Appcore not initialized
11-23 14:03:42.701+0530 D/UXT     (18060): uxt_theme.c: uxt_theme_delete_color_table(654) > color table (b8f50698) is freed
11-23 14:03:42.701+0530 D/UXT     (18060): uxt_theme.c: uxt_theme_delete_font_table(1399) > color table (b91a24c0) is freed
11-23 14:03:42.701+0530 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
11-23 14:03:42.701+0530 W/AUL_AMD (  608): amd_launch.c: __e17_status_handler(3328) > pid(18151) status(3)
11-23 14:03:42.721+0530 D/AUL_PAD (18604): launchpad_loader.c: main(683) > [candidate] ecore handler add
11-23 14:03:42.721+0530 D/AUL_PAD (18604): launchpad_loader.c: main(697) > [candidate] ecore main loop begin
11-23 14:03:42.721+0530 I/MALI    (18060): egl_platform_x11.c: __egl_platform_terminate(358) > [EGL-X11] PID=18060   close drm_fd=30 
11-23 14:03:42.721+0530 E/EFL     (18604): edje<18604> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
11-23 14:03:42.721+0530 E/EFL     (18604): By the power of Grayskull, your previous Embryo stack is now broken!
11-23 14:03:42.721+0530 E/EFL     (18604): edje<18604> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
11-23 14:03:42.721+0530 E/EFL     (18604): By the power of Grayskull, your previous Embryo stack is now broken!
11-23 14:03:42.721+0530 E/EFL     (18604): edje<18604> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
11-23 14:03:42.721+0530 E/EFL     (18604): By the power of Grayskull, your previous Embryo stack is now broken!
11-23 14:03:42.912+0530 D/APP_CORE(18060): appcore-efl.c: appcore_efl_main(1678) > [SECURE_LOG] [task-mgr:Application:Terminate]
11-23 14:03:42.932+0530 D/AUL_PAD ( 1390): launchpad.c: main(675) > pfds[LAUNCH_PAD].revent  : 0x0
11-23 14:03:42.932+0530 D/AUL_PAD ( 1390): launchpad.c: main(677) > pfds[POOL_TYPE + 0].revents : 0x0
11-23 14:03:42.932+0530 D/AUL_PAD ( 1390): launchpad.c: main(678) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
11-23 14:03:42.932+0530 D/AUL_PAD ( 1390): launchpad.c: main(677) > pfds[POOL_TYPE + 1].revents : 0x0
11-23 14:03:42.932+0530 D/AUL_PAD ( 1390): launchpad.c: main(678) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
11-23 14:03:42.932+0530 D/AUL_PAD ( 1390): launchpad.c: main(677) > pfds[POOL_TYPE + 2].revents : 0x0
11-23 14:03:42.932+0530 D/AUL_PAD ( 1390): launchpad.c: main(678) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
11-23 14:03:42.942+0530 I/AUL_PAD ( 1390): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 18060 pgid = 18060
11-23 14:03:42.942+0530 I/AUL_PAD ( 1390): sigchild.h: __sigchild_action(143) > dead_pid(18060)
11-23 14:03:42.962+0530 D/AUL_PAD ( 1390): sigchild.h: __send_app_dead_signal(91) > send dead signal done
11-23 14:03:42.962+0530 I/AUL_PAD ( 1390): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
11-23 14:03:42.962+0530 I/AUL_PAD ( 1390): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
11-23 14:03:42.962+0530 E/AUL_PAD ( 1390): launchpad.c: main(698) > error reading sigchld info
11-23 14:03:42.962+0530 D/STARTER ( 2004): lock-daemon-lite.c: lockd_app_dead_cb_lite(1158) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.53/src/lock-daemon-lite.c:1158:D] app dead cb call! (pid : 18060)
11-23 14:03:42.962+0530 I/ESD     (  882): esd_main.c: __esd_app_dead_handler(1773) > pid: 18060
11-23 14:03:42.962+0530 D/STARTER ( 2004): menu_daemon.c: menu_daemon_check_dead_signal(840) > [menu_daemon_check_dead_signal:840] Process 18060 is termianted
11-23 14:03:42.962+0530 I/Tizen::App( 1185): (243) > App[com.samsung.task-mgr] pid[18060] terminate event is forwarded
11-23 14:03:42.962+0530 I/Tizen::System( 1185): (256) > osp.accessorymanager.service provider is found.
11-23 14:03:42.962+0530 I/Tizen::System( 1185): (196) > Accessory Owner is removed [com.samsung.task-mgr, 18060, ]
11-23 14:03:42.962+0530 I/Tizen::System( 1185): (256) > osp.system.service provider is found.
11-23 14:03:42.962+0530 I/Tizen::App( 1185): (506) > TerminatedApp(com.samsung.task-mgr)
11-23 14:03:42.962+0530 I/Tizen::App( 1185): (512) > Not registered pid(18060)
11-23 14:03:42.962+0530 I/Tizen::System( 1185): (246) > Terminated app [com.samsung.task-mgr]
11-23 14:03:42.962+0530 D/STARTER ( 2004): menu_daemon.c: menu_daemon_check_dead_signal(893) > [menu_daemon_check_dead_signal:893] Unknown process, ignore it (dead pid 18060, home pid 1953, taskmgr pid -1)
11-23 14:03:42.962+0530 I/Tizen::Io( 1185): (729) > Entry not found
11-23 14:03:42.962+0530 W/AUL_AMD (  608): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 18060
11-23 14:03:42.962+0530 W/AUL_AMD (  608): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 18060
11-23 14:03:42.962+0530 D/AUL_AMD (  608): amd_key.c: _unregister_key_event(179) > ===key stack===
11-23 14:03:42.962+0530 D/AUL_AMD (  608): amd_status.c: _status_publish_app_status(1132) > [SECURE_LOG] pid(18060) status(0)
11-23 14:03:42.962+0530 D/AUL_AMD (  608): amd_status.c: _status_publish_app_status(1139) > [SECURE_LOG] pid(18060) appid(com.samsung.task-mgr)
11-23 14:03:42.962+0530 D/AUL_AMD (  608): amd_launch.c: __amd_effect_image_file_set(1472) > [SECURE_LOG] path : com.samsung.task-mgr
11-23 14:03:42.962+0530 D/AUL_AMD (  608): amd_launch.c: __amd_send_message_to_e17(1506) > root win : 5a
11-23 14:03:42.962+0530 D/AUL_AMD (  608): amd_launch.c: __amd_send_message_to_e17(1521) > [LAUNCHING EFFECT]: message type(0), screen mode(0), effect type(-1), theme(0), indicator hide
11-23 14:03:42.962+0530 D/AUL_AMD (  608): amd_launch.c: __amd_send_message_to_e17(1528) > ecore_x_client_message32_send : 1
11-23 14:03:42.962+0530 D/AUL_AMD (  608): amd_status.c: _status_publish_app_status(1160) > [SECURE_LOG] appid(com.samsung.camera-app-lite)
11-23 14:03:42.962+0530 D/AUL_AMD (  608): amd_status.c: __remove_pkg_info(262) > ~STATUS_SERVICE : appid(com.samsung.task-mgr)
11-23 14:03:42.962+0530 D/AUL     (  608): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
11-23 14:03:42.962+0530 D/AUL     (  608): simple_util.c: __trm_app_info_send_socket(354) > send
11-23 14:03:42.962+0530 E/RESOURCED(  667): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1761
11-23 14:03:42.972+0530 D/RESOURCED(  667): proc-monitor.c: proc_dbus_aul_terminated(1119) > received terminated process : pid 18060
11-23 14:03:42.972+0530 I/Tizen::System( 1185): (157) > change brightness system value.
11-23 14:03:42.972+0530 I/Tizen::App( 1185): (782) > Finished invoking application event listener for com.samsung.task-mgr, 18060.
11-23 14:03:42.992+0530 D/RESOURCED(  667): appinfo-list.c: resourced_appinfo_put(132) > appid com.samsung.task-mgr, pkgname = com.samsung.task-mgr, ref = 0
11-23 14:03:42.992+0530 D/RESOURCED(  667): counter-process.c: _process_network_counter(1156) > There is no serialized counters in response
11-23 14:03:42.992+0530 D/RESOURCED(  667): counter-process.c: _process_network_counter(1156) > There is no serialized counters in response
11-23 14:03:42.992+0530 D/RESOURCED(  667): counter-process.c: _process_network_counter(1156) > There is no serialized counters in response
11-23 14:03:42.992+0530 D/RESOURCED(  667): counter-process.c: _process_network_counter(1156) > There is no serialized counters in response
11-23 14:03:43.012+0530 D/AUL_AMD (  608): amd_request.c: __restart_timeout_handler(503) > ri (b8e2a838)
11-23 14:03:43.012+0530 D/AUL_AMD (  608): amd_request.c: __restart_timeout_handler(504) > [SECURE_LOG] appid (com.samsung.weather-m-agent)
11-23 14:03:43.572+0530 W/CRASH_MANAGER(18614): worker.c: worker_job(1199) > 0618151696170144826762
