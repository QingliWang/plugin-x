S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.2
Build-Number: Z300HDDE0BOK3
Build-Date: 2015.11.09 20:13:02

Crash Information
Process Name: iap-test
PID: 1473
Date: 2015-11-23 14:29:22+0530
Executable File Path: /opt/usr/apps/org.example.iap-test/bin/iap-test
Signal: 6
      (SIGABRT)
      si_code: -6
      signal sent by tkill (sent by pid 1473, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x000005c1
r2   = 0x00000006, r3   = 0xb40b84c0
r4   = 0x00000002, r5   = 0xb40b8000
r6   = 0xb67b909c, r7   = 0x0000010c
r8   = 0x00000001, r9   = 0x00000002
r10  = 0x00000007, fp   = 0xbed1a3c0
ip   = 0x00000000, sp   = 0xbed1a184
lr   = 0xb66aff18, pc   = 0xb66aeb84
cpsr = 0x200e0010

Memory Information
MemTotal:   986992 KB
MemFree:    238884 KB
Buffers:     22528 KB
Cached:     303656 KB
VmPeak:     139116 KB
VmSize:     132140 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       35444 KB
VmRSS:       32656 KB
VmData:      40188 KB
VmStk:         136 KB
VmExe:          24 KB
VmLib:       41824 KB
VmPTE:         106 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 1473 TID = 1473
1473 1517 1672 1677 

Maps Information
b0d45000 b1544000 rw-p [stack:1677]
b1544000 b1545000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1555000 b1569000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b15cd000 b1dcc000 rw-p [stack:1672]
b1dcc000 b1f27000 r-xp /usr/lib/egl/libMali.so
b1f3c000 b1fc5000 r-xp /usr/lib/evas/modules/engines/gl_generic/v-1.13/module.so
b1fdd000 b1fe7000 r-xp /usr/lib/evas/modules/engines/gl_x11/v-1.13/module.so
b1ff8000 b2004000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b2346000 b234d000 r-xp /usr/lib/libefl-extension.so.0.1.0
b235e000 b2362000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.18
b2375000 b237b000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b238b000 b279c000 r-xp /opt/usr/apps/org.example.iap-test/bin/iap-test
b2915000 b29f8000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2a2f000 b2a57000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2a69000 b3268000 rw-p [stack:1517]
b3268000 b326a000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b327a000 b3284000 r-xp /lib/libnss_files-2.20-2014.11.so
b3295000 b329e000 r-xp /lib/libnss_nis-2.20-2014.11.so
b32af000 b32c0000 r-xp /lib/libnsl-2.20-2014.11.so
b32d3000 b32d9000 r-xp /lib/libnss_compat-2.20-2014.11.so
b32ea000 b32eb000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b3313000 b331a000 r-xp /usr/lib/libminizip.so.1.0.0
b332a000 b332f000 r-xp /usr/lib/libstorage.so.0.1
b333f000 b33b0000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b33c6000 b33da000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b33ea000 b342e000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b343e000 b3446000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b3456000 b3486000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b3499000 b3552000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b3566000 b35cb000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b35dc000 b35f7000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b3607000 b36c8000 r-xp /usr/lib/libprotobuf.so.9.0.1
b36db000 b36ec000 r-xp /usr/lib/libefl-assist.so.0.1.0
b36fc000 b3709000 r-xp /usr/lib/libmdm-common.so.1.0.97
b371a000 b3721000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b3731000 b3772000 r-xp /usr/lib/libmdm.so.1.2.10
b3782000 b378a000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b3799000 b37a9000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b37ca000 b382a000 r-xp /usr/lib/libasound.so.2.0.0
b383c000 b383f000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b384f000 b3852000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3862000 b3867000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3877000 b3878000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b3888000 b3893000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b38a7000 b38b0000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b38c0000 b38c8000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b38d8000 b38dd000 r-xp /usr/lib/libmmfsession.so.0.0.1
b38ed000 b3909000 r-xp /usr/lib/libmmfsound.so.0.1.0
b391a000 b3921000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3931000 b3935000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3945000 b3973000 r-xp /usr/lib/libidn.so.11.5.44
b3983000 b3999000 r-xp /usr/lib/libnghttp2.so.5.4.0
b39aa000 b39b4000 r-xp /usr/lib/libcares.so.2.1.0
b39c4000 b39ce000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.29
b39de000 b39e0000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b39f0000 b39f1000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3a01000 b3a05000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3a16000 b3a41000 r-xp /usr/lib/libui-extension.so.0.1.0
b3a51000 b3a7a000 r-xp /usr/lib/libturbojpeg.so
b3a9a000 b3aa0000 r-xp /usr/lib/libgif.so.4.1.6
b3ab0000 b3af6000 r-xp /usr/lib/libcurl.so.4.3.0
b3b07000 b3b28000 r-xp /usr/lib/libexif.so.12.3.3
b3b43000 b3b58000 r-xp /usr/lib/libtts.so
b3b69000 b3b71000 r-xp /usr/lib/libfeedback.so.0.1.4
b3b82000 b3c47000 r-xp /usr/lib/libdali-core.so.0.0.0
b3c68000 b3d5f000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3d7f000 b3e4d000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3e64000 b3e66000 r-xp /usr/lib/libboost_system.so.1.51.0
b3e76000 b3e7c000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3e8c000 b3eaf000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3ec0000 b3ec2000 r-xp /usr/lib/libappsvc.so.0.1.0
b3ed2000 b3ed4000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3ee5000 b3eea000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3f01000 b3f03000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3f13000 b3f1a000 r-xp /usr/lib/libsensord-share.so
b3f2a000 b3f42000 r-xp /usr/lib/libsensor.so.1.1.0
b3f53000 b3f56000 r-xp /usr/lib/libXv.so.1.0.0
b3f66000 b3f6b000 r-xp /usr/lib/libutilX.so.1.1.0
b3f7b000 b3f81000 r-xp /usr/lib/libappcore-common.so.1.1
b3f91000 b3f98000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b3fab000 b3faf000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b3fc0000 b409e000 r-xp /usr/lib/libCOREGL.so.4.0
b40be000 b40c1000 r-xp /usr/lib/libuuid.so.1.3.0
b40d1000 b40e8000 r-xp /usr/lib/libblkid.so.1.1.0
b40f9000 b40fb000 r-xp /usr/lib/libXau.so.6.0.0
b410b000 b4152000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b4164000 b416a000 r-xp /usr/lib/libjson-c.so.2.0.1
b417b000 b417f000 r-xp /usr/lib/libogg.so.0.7.1
b418f000 b41b1000 r-xp /usr/lib/libvorbis.so.0.4.3
b41c1000 b42a5000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b42c1000 b42c4000 r-xp /usr/lib/libEGL.so.1.4
b42d5000 b42db000 r-xp /usr/lib/libxcb-render.so.0.0.0
b42eb000 b42ed000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b42fd000 b430a000 r-xp /usr/lib/libGLESv2.so.2.0
b431b000 b437d000 r-xp /usr/lib/libpixman-1.so.0.28.2
b4392000 b43aa000 r-xp /usr/lib/libmount.so.1.1.0
b43bc000 b43d0000 r-xp /usr/lib/libxcb.so.1.1.0
b43e0000 b43e7000 r-xp /lib/libcrypt-2.20-2014.11.so
b441f000 b4421000 r-xp /usr/lib/libiri.so
b4431000 b443c000 r-xp /usr/lib/libgpg-error.so.0.15.0
b444d000 b4483000 r-xp /usr/lib/libpulse.so.0.16.2
b4494000 b44d7000 r-xp /usr/lib/libsndfile.so.1.0.25
b44ec000 b4501000 r-xp /lib/libexpat.so.1.5.2
b4513000 b45d1000 r-xp /usr/lib/libcairo.so.2.11200.14
b45e5000 b45ed000 r-xp /usr/lib/libdrm.so.2.4.0
b45fd000 b4600000 r-xp /usr/lib/libdri2.so.0.0.0
b4610000 b465e000 r-xp /usr/lib/libssl.so.1.0.0
b4673000 b467f000 r-xp /usr/lib/libeeze.so.1.13.0
b4690000 b4699000 r-xp /usr/lib/libethumb.so.1.13.0
b46a9000 b46ac000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b46bc000 b4873000 r-xp /usr/lib/libcrypto.so.1.0.0
b565e000 b5667000 r-xp /usr/lib/libXi.so.6.1.0
b5677000 b5679000 r-xp /usr/lib/libXgesture.so.7.0.0
b5689000 b568d000 r-xp /usr/lib/libXtst.so.6.1.0
b569d000 b56a3000 r-xp /usr/lib/libXrender.so.1.3.0
b56b3000 b56b9000 r-xp /usr/lib/libXrandr.so.2.2.0
b56c9000 b56cb000 r-xp /usr/lib/libXinerama.so.1.0.0
b56dc000 b56df000 r-xp /usr/lib/libXfixes.so.3.1.0
b56ef000 b56fa000 r-xp /usr/lib/libXext.so.6.4.0
b570a000 b570c000 r-xp /usr/lib/libXdamage.so.1.1.0
b571c000 b571e000 r-xp /usr/lib/libXcomposite.so.1.0.0
b572e000 b5810000 r-xp /usr/lib/libX11.so.6.3.0
b5824000 b582b000 r-xp /usr/lib/libXcursor.so.1.0.2
b583b000 b5853000 r-xp /usr/lib/libudev.so.1.6.0
b5855000 b5858000 r-xp /lib/libattr.so.1.1.0
b5868000 b5888000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5889000 b588e000 r-xp /usr/lib/libffi.so.6.0.2
b589f000 b58b7000 r-xp /lib/libz.so.1.2.8
b58c7000 b58c9000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b58d9000 b59ae000 r-xp /usr/lib/libxml2.so.2.9.2
b59c3000 b5a5e000 r-xp /usr/lib/libstdc++.so.6.0.20
b5a7a000 b5a7d000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5a8d000 b5aac000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5abc000 b5acd000 r-xp /lib/libresolv-2.20-2014.11.so
b5ae1000 b5b5b000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5b70000 b5b72000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5b82000 b5b89000 r-xp /usr/lib/libembryo.so.1.13.0
b5b99000 b5ba3000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5bb4000 b5bcc000 r-xp /usr/lib/libpng12.so.0.50.0
b5bdd000 b5c00000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c21000 b5c35000 r-xp /usr/lib/libector.so.1.13.0
b5c46000 b5c5e000 r-xp /usr/lib/liblua-5.1.so
b5c6f000 b5cc6000 r-xp /usr/lib/libfreetype.so.6.11.3
b5cda000 b5d02000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d13000 b5d26000 r-xp /usr/lib/libfribidi.so.0.3.1
b5d37000 b5d71000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d82000 b5d90000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5da0000 b5da8000 r-xp /usr/lib/libtbm.so.1.0.0
b5db8000 b5dc5000 r-xp /usr/lib/libeio.so.1.13.0
b5dd5000 b5dd7000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5de7000 b5dec000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5dfc000 b5e13000 r-xp /usr/lib/libefreet.so.1.13.0
b5e25000 b5e45000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e55000 b5e75000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e77000 b5e7d000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5e8d000 b5e9e000 r-xp /usr/lib/libemotion.so.1.13.0
b5eaf000 b5eb6000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5ec6000 b5ed5000 r-xp /usr/lib/libeo.so.1.13.0
b5ee6000 b5ef8000 r-xp /usr/lib/libecore_input.so.1.13.0
b5f09000 b5f0e000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f1e000 b5f37000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f47000 b5f64000 r-xp /usr/lib/libeet.so.1.13.0
b5f7d000 b5fc5000 r-xp /usr/lib/libeina.so.1.13.0
b5fd6000 b5fe6000 r-xp /usr/lib/libefl.so.1.13.0
b5ff7000 b60dc000 r-xp /usr/lib/libicuuc.so.51.1
b60f9000 b6239000 r-xp /usr/lib/libicui18n.so.51.1
b6250000 b6288000 r-xp /usr/lib/libecore_x.so.1.13.0
b629a000 b629d000 r-xp /lib/libcap.so.2.21
b62ad000 b62d6000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b62e7000 b62ee000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6300000 b6337000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b6348000 b6433000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b6446000 b64bf000 r-xp /usr/lib/libsqlite3.so.0.8.6
b64d1000 b64d6000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b64e6000 b64f1000 r-xp /usr/lib/libvconf.so.0.2.45
b6501000 b6503000 r-xp /usr/lib/libvasum.so.0.3.1
b6513000 b6515000 r-xp /usr/lib/libttrace.so.1.1
b6525000 b6528000 r-xp /usr/lib/libiniparser.so.0
b6538000 b655e000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b656f000 b6574000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6585000 b659c000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b65ad000 b6618000 r-xp /lib/libm-2.20-2014.11.so
b6629000 b662f000 r-xp /lib/librt-2.20-2014.11.so
b6640000 b664d000 r-xp /usr/lib/libunwind.so.8.0.1
b6683000 b67a7000 r-xp /lib/libc-2.20-2014.11.so
b67bc000 b67d5000 r-xp /lib/libgcc_s-4.9.so.1
b67e5000 b68c7000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b68d8000 b6902000 r-xp /usr/lib/libdbus-1.so.3.8.12
b6913000 b694f000 r-xp /usr/lib/libsystemd.so.0.4.0
b6951000 b69d4000 r-xp /usr/lib/libedje.so.1.13.0
b69e7000 b6a05000 r-xp /usr/lib/libecore.so.1.13.0
b6a25000 b6bad000 r-xp /usr/lib/libevas.so.1.13.0
b6be2000 b6bf6000 r-xp /lib/libpthread-2.20-2014.11.so
b6c0a000 b6e3e000 r-xp /usr/lib/libelementary.so.1.13.0
b6e6d000 b6e71000 r-xp /usr/lib/libsmack.so.1.0.0
b6e81000 b6e88000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6e98000 b6e9a000 r-xp /usr/lib/libdlog.so.0.0.0
b6eaa000 b6ead000 r-xp /usr/lib/libbundle.so.0.1.22
b6ebd000 b6ebf000 r-xp /lib/libdl-2.20-2014.11.so
b6ed0000 b6ee9000 r-xp /usr/lib/libaul.so.0.1.0
b6efc000 b6f02000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f14000 b6f21000 r-xp /usr/lib/liblptcp.so
b6f33000 b6f37000 r-xp /usr/lib/libsys-assert.so
b6f48000 b6f68000 r-xp /lib/ld-2.20-2014.11.so
b6f79000 b6f7f000 r-xp /usr/bin/launchpad-loader
b78fc000 b7e0f000 rw-p [heap]
becfa000 bed1b000 rw-p [stack]
b78fc000 b7e0f000 rw-p [heap]
becfa000 bed1b000 rw-p [stack]
End of Maps Information

Callstack Information (PID:1473)
Call Stack Count: 15
 0: gsignal + 0x34 (0xb66aeb84) [/lib/libc.so.6] + 0x2bb84
 1: abort + 0x12c (0xb66aff18) [/lib/libc.so.6] + 0x2cf18
 2: (0xb66ea46c) [/lib/libc.so.6] + 0x6746c
 3: (0xb66f00d4) [/lib/libc.so.6] + 0x6d0d4
 4: (0xb66f0a5c) [/lib/libc.so.6] + 0x6da5c
 5: AppDelegate::~AppDelegate() + 0x14 (0xb23bd651) [/opt/usr/apps/org.example.iap-test/bin/iap-test] + 0x32651
 6: cocos2d::app_terminate(void*) + 0x2a (0xb242cdcb) [/opt/usr/apps/org.example.iap-test/bin/iap-test] + 0xa1dcb
 7: (0xb3fad589) [/usr/lib/libcapi-appfw-application.so.0] + 0x2589
 8: appcore_efl_main + 0x43a (0xb6effd3f) [/usr/lib/libappcore-efl.so.1] + 0x3d3f
 9: ui_app_main + 0xc0 (0xb3fad909) [/usr/lib/libcapi-appfw-application.so.0] + 0x2909
10: cocos2d::Application::run() + 0x60 (0xb242ce45) [/opt/usr/apps/org.example.iap-test/bin/iap-test] + 0xa1e45
11: main + 0x32 (0xb23bfe23) [/opt/usr/apps/org.example.iap-test/bin/iap-test] + 0x34e23
12: (0xb6f7accf) [/opt/usr/apps/org.example.iap-test/bin/iap-test] + 0x1ccf
13: __libc_start_main + 0x114 (0xb66994bc) [/lib/libc.so.6] + 0x164bc
14: (0xb6f7b114) [/opt/usr/apps/org.example.iap-test/bin/iap-test] + 0x2114
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
ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/apps/com.samsung.task-mgr/bin/task-mgr' and package_app_info.app_disable IN ('false','False')
11-23 14:29:20.626+0530 D/AUL_AMD (  593): amd_status.c: _status_get_appid_bypid(959) > [SECURE_LOG] appid for 1550 is com.samsung.task-mgr
11-23 14:29:20.626+0530 D/AUL_AMD (  593): amd_request.c: __request_handler(1184) > APP_GET_APPID_BYPID : 1550 : 0
11-23 14:29:20.626+0530 D/AUL     ( 1004): app_sock.c: __app_send_cmd_with_result(646) > recv result  = 29
11-23 14:29:20.626+0530 E/EFL     (  465): evas-gl_x11<465> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
11-23 14:29:20.626+0530 D/UXT     ( 1550): uxt_theme_private.c: uxt_theme_replace_color(1101) > new code for edje(8000ec77) [rgb: 0,0,0,43] [rgb2: 255,255,255,255] [rgb3: 255,255,255,255]
11-23 14:29:20.626+0530 D/UXT     ( 1550): uxt_theme_private.c: uxt_theme_replace_color(1106) > color code replace: [W012 -> AO001], W012: [rgb: 0,0,0,43] [rgb2: 255,255,255,255] [rgb3: 255,255,255,255]
11-23 14:29:20.626+0530 D/UXT     ( 1550): uxt_theme_private.c: uxt_theme_replace_color(1101) > new code for edje(8000ec77) [rgb: 0,0,0,140] [rgb2: 255,255,255,255] [rgb3: 255,255,255,255]
11-23 14:29:20.626+0530 D/UXT     ( 1550): uxt_theme_private.c: uxt_theme_replace_color(1106) > color code replace: [B043 -> AO001P], B043: [rgb: 0,0,0,140] [rgb2: 255,255,255,255] [rgb3: 255,255,255,255]
11-23 14:29:20.626+0530 D/UXT     ( 1550): uxt_theme_private.c: uxt_theme_replace_color(1101) > new code for edje(8000ec77) [rgb: 0,0,0,25] [rgb2: 255,255,255,255] [rgb3: 255,255,255,255]
11-23 14:29:20.626+0530 D/UXT     ( 1550): uxt_theme_private.c: uxt_theme_replace_color(1106) > color code replace: [W012D -> AO001D], W012D: [rgb: 0,0,0,25] [rgb2: 255,255,255,255] [rgb3: 255,255,255,255]
11-23 14:29:20.636+0530 E/EFL     (  465): evas-gl_x11<465> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
11-23 14:29:20.656+0530 D/TASK_MGR_LITE( 1550): recent_app_viewer.c: create_recent_app_item(1051) > add app: iap-test
11-23 14:29:20.656+0530 E/EFL     (  465): evas-gl_x11<465> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
11-23 14:29:20.666+0530 E/EFL     (  465): evas-gl_x11<465> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
11-23 14:29:20.666+0530 D/LAUNCH  ( 1550): appcore-efl.c: __before_loop(1162) > [task-mgr:Application:create:done]
11-23 14:29:20.677+0530 D/APP_CORE( 1550): appcore-efl.c: __check_wm_rotation_support(841) > Disable window manager rotation
11-23 14:29:20.677+0530 D/APP_CORE( 1550): appcore.c: __aul_handler(581) > [APP 1550]     AUL event: AUL_START
11-23 14:29:20.677+0530 I/APP_CORE( 1550): appcore-efl.c: __do_app(514) > [APP 1550] Event: RESET State: CREATED
11-23 14:29:20.677+0530 D/APP_CORE( 1550): appcore-efl.c: __do_app(545) > [APP 1550] RESET
11-23 14:29:20.677+0530 D/LAUNCH  ( 1550): appcore-efl.c: __do_app(547) > [task-mgr:Application:reset:start]
11-23 14:29:20.677+0530 D/APP_CORE( 1550): appcore-efl.c: __do_app(550) > [__SUSPEND__] reset case
11-23 14:29:20.677+0530 D/APP_CORE( 1550): appcore-efl.c: __appcore_efl_exit_from_suspend(379) > [__SUSPEND__]
11-23 14:29:20.677+0530 I/CAPI_APPFW_APPLICATION( 1550): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
11-23 14:29:20.677+0530 D/LAUNCH  ( 1550): appcore-efl.c: __do_app(560) > [task-mgr:Application:reset:done]
11-23 14:29:20.677+0530 D/APP_CORE( 1550): appcore.c: __aul_handler(602) > [SECURE_LOG] caller_appid : (null)
11-23 14:29:20.677+0530 E/EFL     ( 1550): edje<1550> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
11-23 14:29:20.677+0530 E/EFL     ( 1550): By the power of Grayskull, your previous Embryo stack is now broken!
11-23 14:29:20.677+0530 E/EFL     ( 1550): edje<1550> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
11-23 14:29:20.677+0530 E/EFL     ( 1550): By the power of Grayskull, your previous Embryo stack is now broken!
11-23 14:29:20.687+0530 W/APP_CORE( 1550): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:3400003
11-23 14:29:20.687+0530 D/APP_CORE( 1550): appcore-efl.c: __add_win(759) > [EVENT_TEST][EVENT] __add_win WIN:3400003
11-23 14:29:20.687+0530 D/APP_CORE( 1550): appcore-group.c: appcore_group_attach(13) > appcore_group_attach
11-23 14:29:20.687+0530 D/AUL     ( 1550): app_sock.c: __app_send_raw(288) > pid(-2) : cmd(35)
11-23 14:29:20.687+0530 W/AUL_AMD (  593): amd_request.c: __request_handler(906) > __request_handler: 35
11-23 14:29:20.687+0530 E/EFL     (  465): evas-gl_x11<465> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
11-23 14:29:20.707+0530 E/EFL     (  465): evas-gl_x11<465> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
11-23 14:29:20.807+0530 D/TASK_MGR_LITE( 1550): recent_app_viewer.c: on_scroll_to_cb(1169) > on_scroll_to_cb
11-23 14:29:20.807+0530 D/TASK_MGR_LITE( 1550): recent_app_viewer.c: on_scroll_to_cb(1185) > v_page: 6
11-23 14:29:20.807+0530 D/TASK_MGR_LITE( 1550): recent_app_viewer.c: on_scroller_move(999) > on_scroller_move
11-23 14:29:20.807+0530 D/TASK_MGR_LITE( 1550): recent_app_viewer.c: update_capture_animation(382) > update_capture_animation
11-23 14:29:20.807+0530 D/TASK_MGR_LITE( 1550): recent_app_viewer.c: find_capture_app(184) > v_page: 6
11-23 14:29:20.807+0530 D/TASK_MGR_LITE( 1550): recent_app_viewer.c: find_capture_app(191) > capture app index: 0
11-23 14:29:20.807+0530 D/UXT     (  465): uxt_theme.c: uxt_theme_delete_color_table(654) > color table (b737e960) is freed
11-23 14:29:20.817+0530 W/AUL_AMD (  593): amd_launch.c: __e17_status_handler(3328) > pid(1550) status(0)
11-23 14:29:20.817+0530 D/AUL_AMD (  593): amd_launch.c: __send_cpu_boost(538) > __send_cpu_boost enter
11-23 14:29:20.817+0530 D/AUL_AMD (  593): amd_launch.c: __send_cpu_boost(563) > __send_cpu_boost ok
11-23 14:29:20.817+0530 D/LAUNCH  (  593): amd_launch.c: __e17_status_handler(3384) > [task-mgr:Application:Launching:done]
11-23 14:29:20.817+0530 W/AUL_AMD (  593): amd_launch.c: __e17_status_handler(3328) > pid(1550) status(0)
11-23 14:29:20.817+0530 D/AUL_AMD (  593): amd_launch.c: __send_cpu_boost(538) > __send_cpu_boost enter
11-23 14:29:20.817+0530 D/AUL_AMD (  593): amd_launch.c: __send_cpu_boost(563) > __send_cpu_boost ok
11-23 14:29:20.817+0530 D/LAUNCH  (  593): amd_launch.c: __e17_status_handler(3384) > [task-mgr:Application:Launching:done]
11-23 14:29:20.827+0530 D/APP_CORE( 1473): appcore-efl.c: __update_win(805) > [EVENT_TEST][EVENT] __update_win WIN:5800003 fully_obscured 1
11-23 14:29:20.827+0530 D/APP_CORE( 1473): appcore-efl.c: __visibility_cb(980) > bvisibility 0, b_active 1
11-23 14:29:20.827+0530 D/APP_CORE( 1473): appcore-efl.c: __visibility_cb(995) >  Go to Pasue state 
11-23 14:29:20.827+0530 I/APP_CORE( 1473): appcore-efl.c: __do_app(514) > [APP 1473] Event: PAUSE State: RUNNING
11-23 14:29:20.827+0530 D/APP_CORE( 1473): appcore-efl.c: __do_app(581) > [APP 1473] PAUSE
11-23 14:29:20.827+0530 I/CAPI_APPFW_APPLICATION( 1473): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
11-23 14:29:20.827+0530 D/APP_CORE( 1473): appcore-efl.c: __trm_app_info_send_socket(241) > __trm_app_info_send_socket
11-23 14:29:20.827+0530 W/AUL_AMD (  593): amd_launch.c: __e17_status_handler(3328) > pid(1473) status(4)
11-23 14:29:20.827+0530 D/AUL_AMD (  593): amd_status.c: _status_update_app_info_list(431) > pid(1473) status(4)
11-23 14:29:20.827+0530 D/AUL_AMD (  593): amd_status.c: _status_update_app_info_list(442) > pid(1473) appid(org.example.iap-test) pkgid(org.example.iap-test) status(4)
11-23 14:29:20.827+0530 W/AUL     (  593): amd_app_group.c: __set_fg_flag(190) > send_signal BG org.example.iap-test(1473)
11-23 14:29:20.827+0530 W/AUL     (  593): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1473, appid: org.example.iap-test, status: bg
11-23 14:29:20.827+0530 D/APP_CORE( 1473): appcore-efl.c: __trm_app_info_send_socket(268) > send
11-23 14:29:20.827+0530 D/QUICKPANEL(  885): QuickpanelApp.cpp: __onEcoreEventMsgReceived(925) > [0;34m>>>HIT<<<[0;m
11-23 14:29:20.827+0530 I/samsung-log-manager( 1342): SLogMgr_UseAppStatusMonitor.cpp: DbusSignalHandlerAppFw(233) > [SECURE_LOG] [(233)]: Background 1473 org.example.iap-test
11-23 14:29:20.827+0530 D/RESOURCED(  709): heart-cpu.c: heart_cpu_write_data(168) > heart_cpu_write_data : pid = 1473, appname = org.example.iap-test, pkgname = org.example.iap-test, type=2
11-23 14:29:20.827+0530 D/RESOURCED(  709): cgroup.c: cgroup_read_node(153) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/net_cls/org.example.iap-test/net_cls.classid, value 20
11-23 14:29:20.827+0530 W/AUL_AMD (  593): amd_launch.c: __e17_status_handler(3328) > pid(1550) status(3)
11-23 14:29:20.827+0530 D/AUL_AMD (  593): amd_key.c: _key_ungrab(265) > _key_ungrab, win : e00002
11-23 14:29:20.827+0530 D/RESOURCED(  709): cpu.c: cpu_background_state(275) > cpu_background_state : pid = 1473, appname = org.example.iap-test
11-23 14:29:20.827+0530 D/RESOURCED(  709): cgroup.c: cgroup_write_node(133) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/background/cgroup.procs, value 1473
11-23 14:29:20.827+0530 I/samsung-log-manager( 1342): SLogMgr_NativeDbHelper.cpp: ExecQuery(180) > [SECURE_LOG] [(180)]: query tmp [INSERT INTO use_app_survey(app_id,duration,timestamp,time_zone) VALUES ('org.example.iap-test',43420,1448269160835,'Asia/Kolkata');]
11-23 14:29:20.827+0530 D/RESOURCED(  709): proc-process.c: proc_backgrd_manage(191) > BACKGRD : process 1475 set score 330 (before 300)
11-23 14:29:20.827+0530 D/RESOURCED(  709): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1693) > pid: 1475, proc_name: com.samsung.camera-app-lite, cg_name: background, oom_score_adj: 330
11-23 14:29:20.827+0530 D/RESOURCED(  709): cgroup.c: cgroup_write_node(133) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/background//cgroup.procs, value 1475
11-23 14:29:20.827+0530 W/AUL_AMD (  593): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
11-23 14:29:20.827+0530 W/AUL_AMD (  593): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
11-23 14:29:20.827+0530 D/AUL_AMD (  593): amd_launch.c: __send_cpu_boost(538) > __send_cpu_boost enter
11-23 14:29:20.827+0530 D/AUL_AMD (  593): amd_launch.c: __send_cpu_boost(563) > __send_cpu_boost ok
11-23 14:29:20.827+0530 D/AUL_AMD (  593): amd_status.c: _status_update_app_info_list(431) > pid(1550) status(3)
11-23 14:29:20.827+0530 D/AUL_AMD (  593): amd_status.c: _status_update_app_info_list(442) > pid(1550) appid(com.samsung.task-mgr) pkgid(com.samsung.task-mgr) status(3)
11-23 14:29:20.827+0530 D/QUICKPANEL(  885): QuickpanelApp.cpp: __onEcoreEventMsgReceived(925) > [0;34m>>>HIT<<<[0;m
11-23 14:29:20.827+0530 W/AUL     (  593): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.task-mgr(1550)
11-23 14:29:20.827+0530 W/AUL     (  593): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1550, appid: com.samsung.task-mgr, status: fg
11-23 14:29:20.837+0530 E/EFL     (  465): evas-gl_x11<465> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
11-23 14:29:20.837+0530 D/APP_CORE( 1550): appcore.c: __prt_ltime(235) > [APP 1550] first idle after reset: 541 msec
11-23 14:29:20.847+0530 D/APP_CORE( 1550): appcore-efl.c: __update_win(805) > [EVENT_TEST][EVENT] __update_win WIN:3400003 fully_obscured 0
11-23 14:29:20.847+0530 D/APP_CORE( 1550): appcore-efl.c: __visibility_cb(980) > bvisibility 1, b_active -1
11-23 14:29:20.847+0530 D/APP_CORE( 1550): appcore-efl.c: __visibility_cb(983) >  Go to Resume state
11-23 14:29:20.847+0530 D/PKGMGR_INFO( 1342): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_add_string(3467) > [SECURE_LOG] First value is 'http://tizen.org/category/lockapp'
11-23 14:29:20.847+0530 I/APP_CORE( 1550): appcore-efl.c: __do_app(514) > [APP 1550] Event: RESUME State: CREATED
11-23 14:29:20.847+0530 D/LAUNCH  ( 1550): appcore-efl.c: __do_app(610) > [task-mgr:Application:resume:start]
11-23 14:29:20.847+0530 D/APP_CORE( 1550): appcore-efl.c: __do_app(613) > [__SUSPEND__] resume case
11-23 14:29:20.847+0530 D/APP_CORE( 1550): appcore-efl.c: __appcore_efl_exit_from_suspend(379) > [__SUSPEND__]
11-23 14:29:20.847+0530 D/APP_CORE( 1550): appcore-efl.c: __do_app(618) > [APP 1550] RESUME
11-23 14:29:20.847+0530 D/PKGMGR_INFO( 1342): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_count(3547) > [SECURE_LOG] where = package_app_app_category.category IN ('http://tizen.org/category/lockapp') and package_app_info.app_id='com.samsung.task-mgr' and package_app_info.app_disable IN ('false','False')
11-23 14:29:20.847+0530 D/PKGMGR_INFO( 1342): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_count(3553) > [SECURE_LOG] query = select DISTINCT package_app_info.app_id, package_app_info.app_component, package_app_info.app_installed_storage from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale='en-gb' LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_app_category.category IN ('http://tizen.org/category/lockapp') and package_app_info.app_id='com.samsung.task-mgr' and package_app_info.app_disable IN ('false','False')
11-23 14:29:20.847+0530 I/TIZEN_N_EFL_UTIL_WINDOW( 1473): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 25
11-23 14:29:20.847+0530 E/APP_CORE( 1473): appcore-efl.c: _capture_and_make_file(1619) > win[5800003] widget[720] height[1280]
11-23 14:29:20.847+0530 D/AUL     ( 1473): app_sock.c: __app_send_raw(288) > pid(-2) : cmd(33)
11-23 14:29:20.847+0530 W/AUL_AMD (  593): amd_request.c: __request_handler(906) > __request_handler: 33
11-23 14:29:20.857+0530 D/AUL     ( 1473): pkginfo.c: aul_app_get_appid_bypid(238) > [SECURE_LOG] appid for 1473 is org.example.iap-test
11-23 14:29:20.857+0530 D/PKGMGR_INFO( 1342): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_add_string(3467) > [SECURE_LOG] First value is 'http://tizen.org/category/homeapp'
11-23 14:29:20.857+0530 D/PKGMGR_INFO( 1342): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_count(3547) > [SECURE_LOG] where = package_app_app_category.category IN ('http://tizen.org/category/homeapp') and package_app_info.app_id='com.samsung.task-mgr' and package_app_info.app_disable IN ('false','False')
11-23 14:29:20.857+0530 D/PKGMGR_INFO( 1342): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_count(3553) > [SECURE_LOG] query = select DISTINCT package_app_info.app_id, package_app_info.app_component, package_app_info.app_installed_storage from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale='en-gb' LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_app_category.category IN ('http://tizen.org/category/homeapp') and package_app_info.app_id='com.samsung.task-mgr' and package_app_info.app_disable IN ('false','False')
11-23 14:29:20.857+0530 I/samsung-log-manager( 1342): SLogMgr_UseAppStatusMonitor.cpp: DbusSignalHandlerAppFw(218) > [SECURE_LOG] [(218)]: Foreground 1550 com.samsung.task-mgr
11-23 14:29:20.857+0530 I/APP_CORE( 1550): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
11-23 14:29:20.857+0530 I/APP_CORE( 1550): appcore-efl.c: __do_app(625) > [APP 1550] Initial Launching, call the resume_cb
11-23 14:29:20.857+0530 I/CAPI_APPFW_APPLICATION( 1550): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
11-23 14:29:20.857+0530 D/LAUNCH  ( 1550): appcore-efl.c: __do_app(647) > [task-mgr:Application:resume:done]
11-23 14:29:20.857+0530 D/APP_CORE( 1550): appcore-efl.c: __trm_app_info_send_socket(241) > __trm_app_info_send_socket
11-23 14:29:20.857+0530 D/APP_CORE( 1550): appcore-efl.c: __trm_app_info_send_socket(268) > send
11-23 14:29:20.917+0530 D/RESOURCED(  709): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1693) > pid: 1473, proc_name: org.example.iap-test, cg_name: previous, oom_score_adj: 300
11-23 14:29:20.917+0530 D/RESOURCED(  709): cgroup.c: cgroup_write_node(133) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/previous//cgroup.procs, value 1473
11-23 14:29:20.927+0530 E/EFL     (  881): ecore_x<881> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=1075452
11-23 14:29:20.927+0530 D/STARTER (  761): hw_key.c: _key_release_cb(552) > [_key_release_cb:552] _key_release_cb : XF86Home Released
11-23 14:29:20.927+0530 W/STARTER (  761): hw_key.c: _key_release_cb(580) > [_key_release_cb:580] Home Key is released
11-23 14:29:20.927+0530 E/EFL     (  881): evas_events.c: _evas_canvas_event_feed_key_up_with_keycode(3010) > [SECURE_LOG] Evas KeyEvent:release time=1075452 keyname = XF86Home key = XF86Home keycode = 147
11-23 14:29:20.927+0530 D/STARTER (  761): lock-daemon-lite.c: lockd_get_hall_status(360) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.53/src/lock-daemon-lite.c:360:D] [ == lockd_get_hall_status == ]
11-23 14:29:20.927+0530 E/STARTER (  761): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(340) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.53/src/lock-daemon-lite.c:340:E] dbus_connection_send error(No reply)
11-23 14:29:20.927+0530 E/STARTER (  761): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(344) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.53/src/lock-daemon-lite.c:344:E] dbus_connection_send error(org.freedesktop.DBus.Error.UnknownMethod:Method "getstatus" with signature "" on interface "org.tizen.system.deviced.hall" doesn't exist
11-23 14:29:20.927+0530 E/STARTER (  761): )
11-23 14:29:20.927+0530 D/STARTER (  761): hw_key.c: _key_release_cb(618) > [_key_release_cb:618] delete cancelkey timer
11-23 14:29:20.927+0530 I/SYSPOPUP(  884): syspopup.c: __X_syspopup_term_handler(98) > enter syspopup term handler
11-23 14:29:20.927+0530 I/SYSPOPUP(  884): syspopup.c: __X_syspopup_term_handler(108) > term action 1 - volume
11-23 14:29:20.927+0530 D/VOLUME  (  884): volume_control.c: volume_control_close(828) > [volume_control_close:828] Start closing volume
11-23 14:29:20.927+0530 E/VOLUME  (  884): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
11-23 14:29:20.927+0530 E/VOLUME  (  884): volume_control.c: volume_control_close(841) > [volume_control_close:841] Failed to unregister x input event handler
11-23 14:29:20.937+0530 D/VOLUME  (  884): volume_key_event.c: volume_key_event_key_ungrab(179) > [volume_key_event_key_ungrab:179] key ungrabed
11-23 14:29:20.937+0530 D/VOLUME  (  884): volume_control.c: volume_control_close(853) > [volume_control_close:853] ungrab key : 1/1
11-23 14:29:20.937+0530 D/VOLUME  (  884): volume_key_event.c: volume_key_event_key_grab(128) > [volume_key_event_key_grab:128] count_grabed : 1
11-23 14:29:20.937+0530 D/VOLUME  (  884): volume_control.c: volume_control_close(875) > [volume_control_close:875] End closing volume
11-23 14:29:20.997+0530 D/RESOURCED(  709): counter-process.c: _process_network_counter(1156) > There is no serialized counters in response
11-23 14:29:20.997+0530 D/RESOURCED(  709): proc-main.c: resourced_proc_status_change(877) > [SECURE_LOG] set foreground : 1550
11-23 14:29:20.997+0530 D/RESOURCED(  709): counter-process.c: _process_network_counter(1156) > There is no serialized counters in response
11-23 14:29:21.007+0530 D/TASK_MGR_LITE( 1550): capture_inotify.c: on_fd_inotify_cb(19) > on_fd_inotify_cb
11-23 14:29:21.007+0530 D/TASK_MGR_LITE( 1550): capture_inotify.c: on_fd_inotify_cb(87) > A jpeg file (org.example.iap-test.jpg) is added or modified now
11-23 14:29:21.007+0530 D/TASK_MGR_LITE( 1550): recent_app_viewer.c: update_app_capture(1640) > update capture file: /opt/usr/share/app_capture/org.example.iap-test.jpg
11-23 14:29:21.007+0530 E/EFL     ( 1473): ecore_x<1473> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=1075452
11-23 14:29:21.007+0530 E/EFL     ( 1473): evas_events.c: _evas_canvas_event_feed_key_up_with_keycode(3010) > [SECURE_LOG] Evas KeyEvent:release time=1075452 keyname = XF86Home key = XF86Home keycode = 147
11-23 14:29:21.437+0530 D/AUL_PAD ( 1472): launchpad.c: __send_launchpad_loader(439) > Prepare another candidate process
11-23 14:29:21.437+0530 D/AUL_PAD ( 1692): sigchild.h: __signal_unblock_sigchld(225) > SIGCHLD unblocked
11-23 14:29:21.467+0530 D/AUL_PAD ( 1472): sigchild.h: __send_app_launch_signal(132) > send launch signal done
11-23 14:29:21.477+0530 D/PKGMGR_INFO( 1363): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3662) > [SECURE_LOG] where = package_app_info.app_exec='/usr/apps/com.samsung.task-mgr/bin/task-mgr' and package_app_info.app_disable IN ('false','False')
11-23 14:29:21.477+0530 D/PKGMGR_INFO( 1363): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3668) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-gb') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/apps/com.samsung.task-mgr/bin/task-mgr' and package_app_info.app_disable IN ('false','False')
11-23 14:29:21.487+0530 D/AUL     ( 1363): pkginfo.c: aul_app_get_appid_bypid(238) > [SECURE_LOG] appid for 1550 is com.samsung.task-mgr
11-23 14:29:21.487+0530 I/Tizen::App( 1363): (499) > LaunchedApp(com.samsung.task-mgr)
11-23 14:29:21.487+0530 I/Tizen::App( 1363): (733) > Finished invoking application event listener for com.samsung.task-mgr, 1550.
11-23 14:29:21.557+0530 D/AUL_PAD ( 1692): launchpad_loader.c: main(584) > [candidate] Another candidate process was forked.
11-23 14:29:21.557+0530 D/AUL_PAD ( 1692): preload.h: __preload_init(52) > max_cmdline_size = 1053
11-23 14:29:21.587+0530 D/AUL_PAD ( 1692): preload.h: __preload_init(65) > preload /usr/lib/libappcore-efl.so.1# - handle : b85b5d00
11-23 14:29:21.587+0530 D/AUL_PAD ( 1692): preload.h: __preload_init(69) > get pre-initialization function
11-23 14:29:21.587+0530 D/AUL_PAD ( 1692): preload.h: __preload_init(73) > get shutdown function
11-23 14:29:21.587+0530 D/AUL_PAD ( 1692): preload.h: __preload_init(65) > preload /usr/lib/libappcore-common.so.1# - handle : b85ab3f0
11-23 14:29:21.597+0530 D/AUL_PAD ( 1692): preload.h: __preload_init(65) > preload /usr/lib/libcapi-appfw-application.so.0# - handle : b85ad640
11-23 14:29:21.597+0530 D/AUL_PAD ( 1692): preload.h: __preload_init(69) > get pre-initialization function
11-23 14:29:21.597+0530 D/AUL_PAD ( 1692): preload.h: __preload_init(73) > get shutdown function
11-23 14:29:21.607+0530 D/AUL_PAD ( 1692): process_pool_preload.h: __preload_init_for_process_pool(100) > preload /usr/lib/libboost_thread.so.1.51.0 - handle : b85ae7f0
11-23 14:29:21.788+0530 D/AUL_PAD ( 1692): process_pool_preload.h: __preload_init_for_process_pool(100) > preload /usr/lib/libdali-toolkit.so - handle : b85af5f8
11-23 14:29:21.788+0530 D/AUL_PAD ( 1692): process_pool_preload.h: __preload_init_for_process_pool(100) > preload /usr/lib/libcairo.so - handle : b461f000
11-23 14:29:21.798+0530 D/AUL_PAD ( 1692): process_pool_preload.h: __preload_init_for_process_pool(100) > preload /usr/lib/libefl-assist.so.0 - handle : b85c22c8
11-23 14:29:21.838+0530 D/AUL_PAD ( 1692): process_pool_preload.h: __preload_init_for_process_pool(100) > preload /usr/lib/libprotobuf.so - handle : b85c2960
11-23 14:29:21.878+0530 D/AUL_PAD ( 1692): process_pool_preload.h: __preload_init_for_process_pool(100) > preload /usr/lib/libcapi-media-player.so.0 - handle : b85c4150
11-23 14:29:21.908+0530 D/AUL_PAD ( 1692): process_pool_preload.h: __preload_init_for_process_pool(100) > preload /usr/lib/libcapi-media-camera.so.0 - handle : b85c6d48
11-23 14:29:21.908+0530 D/AUL_PAD ( 1692): preexec.h: __preexec_init(76) > preexec start
11-23 14:29:21.908+0530 D/AUL_PAD ( 1692): preexec.h: __preexec_init(106) > preexec tpk /usr/lib/libosp-env-config.so# - handle : b85c3d80
11-23 14:29:21.908+0530 D/AUL     ( 1692): process_pool.c: __connect_to_launchpad(107) > [launchpad] enter, type: 2
11-23 14:29:21.908+0530 D/AUL     ( 1692): process_pool.c: __connect_to_launchpad(119) > connect to /tmp/.launchpad-type2
11-23 14:29:21.908+0530 D/AUL     ( 1692): process_pool.c: __connect_to_launchpad(132) > send(1692) : 4
11-23 14:29:21.908+0530 D/AUL     ( 1692): process_pool.c: __connect_to_launchpad(139) > [SECURE_LOG] [launchpad] done, connect fd: 9
11-23 14:29:21.908+0530 D/AUL_PAD ( 1472): launchpad.c: main(675) > pfds[LAUNCH_PAD].revent  : 0x0
11-23 14:29:21.908+0530 D/AUL_PAD ( 1472): launchpad.c: main(677) > pfds[POOL_TYPE + 0].revents : 0x0
11-23 14:29:21.908+0530 D/AUL_PAD ( 1472): launchpad.c: main(678) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
11-23 14:29:21.908+0530 D/AUL_PAD ( 1472): launchpad.c: main(677) > pfds[POOL_TYPE + 1].revents : 0x0
11-23 14:29:21.908+0530 D/AUL_PAD ( 1472): launchpad.c: main(678) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
11-23 14:29:21.908+0530 D/AUL_PAD ( 1472): launchpad.c: main(677) > pfds[POOL_TYPE + 2].revents : 0x1
11-23 14:29:21.908+0530 D/AUL_PAD ( 1472): launchpad.c: main(678) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
11-23 14:29:21.908+0530 D/AUL_PAD ( 1472): launchpad.c: main(717) > pfds[POOL_TYPE + 2].revents & POLLIN
11-23 14:29:21.908+0530 D/AUL_PAD ( 1472): launchpad.c: main(729) > [SECURE_LOG] Type 2 candidate process was connected, pid: 1692
11-23 14:29:21.958+0530 D/AUL_AMD (  593): amd_request.c: __add_history_handler(412) > [SECURE_LOG] appid: com.samsung.task-mgr, alias_appid: com.samsung.task-mgr
11-23 14:29:21.958+0530 D/AUL_AMD (  593): amd_request.c: __add_history_handler(434) > [SECURE_LOG] add rua history com.samsung.task-mgr /usr/apps/com.samsung.task-mgr/bin/task-mgr
11-23 14:29:21.958+0530 D/RUA     (  593): rua.c: rua_add_history(179) > rua_add_history start
11-23 14:29:21.968+0530 D/RUA     (  593): rua.c: rua_add_history(247) > rua_add_history ok
11-23 14:29:21.998+0530 E/EFL     ( 1550): ecore_x<1550> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=1076522
11-23 14:29:21.998+0530 E/EFL     ( 1550): evas_events.c: _evas_canvas_event_feed_mouse_down(1171) > [SECURE_LOG] ButtonEvent:down time=1076522 x=262 y=1198 button=1 downs=0 grabbed=0
11-23 14:29:21.998+0530 E/EFL     ( 1550): evas_events.c: _evas_canvas_event_feed_mouse_down(1267) > [SECURE_LOG] ButtonEvent:candidate object count=1
11-23 14:29:21.998+0530 E/EFL     ( 1550): evas_events.c: _evas_input_debug_info(3412) > [SECURE_LOG] [Press] button:1, [262,1198], obj : 0xb90aac98, smart : 0x8000ec77, edje, [150,1182,420,78], event:[0,1], time:[1076522]
11-23 14:29:21.998+0530 E/EFL     ( 1550): evas_events.c: _evas_canvas_event_feed_mouse_down(1306) > [SECURE_LOG] del:0, layer:[0xb8f60210,0], 0
11-23 14:29:22.138+0530 E/EFL     ( 1550): ecore_x<1550> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=1076666
11-23 14:29:22.138+0530 E/EFL     ( 1550): evas_events.c: _evas_canvas_event_feed_mouse_up(1481) > [SECURE_LOG] ButtonEvent:up time=1076666 x=262 y=1198 button=1 downs=1
11-23 14:29:22.138+0530 E/EFL     ( 1550): evas_events.c: _evas_input_debug_info(3412) > [SECURE_LOG] [Release] button:1, [262,1198], obj : 0xb90aac98, smart : 0x8000ec77, edje, [150,1182,420,78], event:[0,1], time:[1076666]
11-23 14:29:22.138+0530 D/TASK_MGR_LITE( 1550): recent_app_viewer.c: on_close_all_clicked(1382) > clicked close all applications button
11-23 14:29:22.138+0530 D/TASK_MGR_LITE( 1550): recent_app_viewer.c: close_all_animation(1366) > close_all_animation
11-23 14:29:22.148+0530 D/TASK_MGR_LITE( 1550): recent_app_viewer.c: close_all_animation_cb(1337) > close_all_animation_cb, pos: 0.020344
11-23 14:29:22.168+0530 D/TASK_MGR_LITE( 1550): recent_app_viewer.c: close_all_animation_cb(1337) > close_all_animation_cb, pos: 0.075884
11-23 14:29:22.178+0530 D/TASK_MGR_LITE( 1550): recent_app_viewer.c: close_all_animation_cb(1337) > close_all_animation_cb, pos: 0.131324
11-23 14:29:22.198+0530 D/TASK_MGR_LITE( 1550): recent_app_viewer.c: close_all_animation_cb(1337) > close_all_animation_cb, pos: 0.186767
11-23 14:29:22.218+0530 D/TASK_MGR_LITE( 1550): recent_app_viewer.c: close_all_animation_cb(1337) > close_all_animation_cb, pos: 0.242207
11-23 14:29:22.218+0530 D/UXT     ( 1692): uxt_theme_private.c: uxt_theme_get_table_number(634) > index: 999, hsv: 230, 92, 74
11-23 14:29:22.218+0530 D/UXT     ( 1692): uxt_theme_private.c: uxt_theme_get_table_number(656) > input color table for theme index (999): ChangeableColorTable1.xml
11-23 14:29:22.218+0530 D/UXT     ( 1692): uxt_theme.c: uxt_theme_add_color_table(620) > color table (b87074f8) from (/usr/share/themes/ChangeableColorTable1.xml) is created
11-23 14:29:22.218+0530 D/UXT     ( 1692): uxt_theme_private.c: uxt_theme_get_core_color_list(1748) > core base color index : 0 (/usr/share/themes/ChangeableColorTable1.xml)
11-23 14:29:22.218+0530 I/UXT     ( 1692): Uxt_ObjectManager.cpp: OnInitialized(734) > Initialized.
11-23 14:29:22.228+0530 D/TASK_MGR_LITE( 1550): recent_app_viewer.c: close_all_animation_cb(1337) > close_all_animation_cb, pos: 0.297647
11-23 14:29:22.238+0530 D/AUL_PAD ( 1692): launchpad_loader.c: main(620) > [candidate] elm init, returned: 1
11-23 14:29:22.248+0530 D/TASK_MGR_LITE( 1550): recent_app_viewer.c: close_all_animation_cb(1337) > close_all_animation_cb, pos: 0.353187
11-23 14:29:22.268+0530 D/TASK_MGR_LITE( 1550): recent_app_viewer.c: close_all_animation_cb(1337) > close_all_animation_cb, pos: 0.408627
11-23 14:29:22.268+0530 E/TBM     ( 1692): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
11-23 14:29:22.268+0530 I/MALI    ( 1692): egl_platform_x11.c: __egl_platform_initialize(242) > [EGL-X11] PID=1692   open drm_fd=30 
11-23 14:29:22.278+0530 D/TASK_MGR_LITE( 1550): recent_app_viewer.c: close_all_animation_cb(1337) > close_all_animation_cb, pos: 0.464067
11-23 14:29:22.298+0530 D/TASK_MGR_LITE( 1550): recent_app_viewer.c: close_all_animation_cb(1337) > close_all_animation_cb, pos: 0.519511
11-23 14:29:22.318+0530 D/TASK_MGR_LITE( 1550): recent_app_viewer.c: close_all_animation_cb(1337) > close_all_animation_cb, pos: 0.575051
11-23 14:29:22.328+0530 D/TASK_MGR_LITE( 1550): recent_app_viewer.c: close_all_animation_cb(1337) > close_all_animation_cb, pos: 0.630491
11-23 14:29:22.348+0530 D/TASK_MGR_LITE( 1550): recent_app_viewer.c: close_all_animation_cb(1337) > close_all_animation_cb, pos: 0.685931
11-23 14:29:22.368+0530 D/TASK_MGR_LITE( 1550): recent_app_viewer.c: close_all_animation_cb(1337) > close_all_animation_cb, pos: 0.741474
11-23 14:29:22.378+0530 D/TASK_MGR_LITE( 1550): recent_app_viewer.c: close_all_animation_cb(1337) > close_all_animation_cb, pos: 0.796914
11-23 14:29:22.398+0530 D/AUL_PAD ( 1692): launchpad_loader.c: main(683) > [candidate] ecore handler add
11-23 14:29:22.398+0530 D/AUL_PAD ( 1692): launchpad_loader.c: main(697) > [candidate] ecore main loop begin
11-23 14:29:22.398+0530 D/TASK_MGR_LITE( 1550): recent_app_viewer.c: close_all_animation_cb(1337) > close_all_animation_cb, pos: 0.852354
11-23 14:29:22.398+0530 E/EFL     ( 1692): edje<1692> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
11-23 14:29:22.398+0530 E/EFL     ( 1692): By the power of Grayskull, your previous Embryo stack is now broken!
11-23 14:29:22.398+0530 E/EFL     ( 1692): edje<1692> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
11-23 14:29:22.398+0530 E/EFL     ( 1692): By the power of Grayskull, your previous Embryo stack is now broken!
11-23 14:29:22.398+0530 E/EFL     ( 1692): edje<1692> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
11-23 14:29:22.398+0530 E/EFL     ( 1692): By the power of Grayskull, your previous Embryo stack is now broken!
11-23 14:29:22.418+0530 D/TASK_MGR_LITE( 1550): recent_app_viewer.c: close_all_animation_cb(1337) > close_all_animation_cb, pos: 0.907794
11-23 14:29:22.428+0530 D/TASK_MGR_LITE( 1550): recent_app_viewer.c: close_all_animation_cb(1337) > close_all_animation_cb, pos: 0.963234
11-23 14:29:22.448+0530 D/TASK_MGR_LITE( 1550): recent_app_viewer.c: close_all_animation_cb(1337) > close_all_animation_cb, pos: 1.000000
11-23 14:29:22.448+0530 D/TASK_MGR_LITE( 1550): recent_app_viewer.c: close_all_animation_cb(1355) > Fade out End !! 
11-23 14:29:22.448+0530 D/TASK_MGR_LITE( 1550): recent_app_viewer.c: quit_idler_cb(1323) > Quit idler, call elm_exit()
11-23 14:29:22.448+0530 D/TASK_MGR_LITE( 1550): recent_app_viewer.c: show_no_app_label(1399) > show_no_app_label
11-23 14:29:22.448+0530 D/AUL     ( 1550): app_sock.c: __app_send_raw_with_noreply(387) > pid(-2) : cmd(22)
11-23 14:29:22.448+0530 W/AUL_AMD (  593): amd_request.c: __request_handler(906) > __request_handler: 22
11-23 14:29:22.448+0530 W/AUL_AMD (  593): amd_request.c: __request_handler(1201) > app status : 5
11-23 14:29:22.448+0530 D/AUL_AMD (  593): amd_status.c: _status_update_app_info_list(431) > pid(1550) status(5)
11-23 14:29:22.448+0530 D/AUL_AMD (  593): amd_status.c: _status_update_app_info_list(442) > pid(1550) appid(com.samsung.task-mgr) pkgid(com.samsung.task-mgr) status(5)
11-23 14:29:22.448+0530 W/AUL     (  593): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.task-mgr(1550)
11-23 14:29:22.448+0530 W/AUL     (  593): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1550, appid: com.samsung.task-mgr, status: bg
11-23 14:29:22.448+0530 D/APP_CORE( 1550): appcore-efl.c: __check_skip(707) > ret(0), win(3400003), state(0), num(0)
11-23 14:29:22.448+0530 D/APP_CORE( 1550): appcore-efl.c: __after_loop(1177) > [APP 1550] PAUSE before termination
11-23 14:29:22.448+0530 I/CAPI_APPFW_APPLICATION( 1550): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
11-23 14:29:22.448+0530 D/TASK_MGR_LITE( 1550): task-mgr-lite.c: _pause_app(398) > _pause_app
11-23 14:29:22.448+0530 W/TASK_MGR_LITE( 1550): task-mgr-lite.c: _pause_app(403) > 
11-23 14:29:22.448+0530 I/CAPI_APPFW_APPLICATION( 1550): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
11-23 14:29:22.448+0530 D/TASK_MGR_LITE( 1550): task-mgr-lite.c: _terminate_app(348) > _terminate_app
11-23 14:29:22.448+0530 D/TASK_MGR_LITE( 1550): task-mgr-lite.c: task_mgr_close_all(106) > task_mgr_close_all
11-23 14:29:22.448+0530 D/TASK_MGR_LITE( 1550): recent_apps.c: recent_apps_kill_selected(182) > kill app, appid: org.example.iap-test
11-23 14:29:22.448+0530 D/TASK_MGR_LITE( 1550): recent_apps.c: recent_apps_kill_selected(185) > kill app, pid: 1473
11-23 14:29:22.448+0530 D/AUL     ( 1550): app_sock.c: __app_send_raw(288) > pid(-2) : cmd(14)
11-23 14:29:22.458+0530 W/AUL_AMD (  593): amd_request.c: __request_handler(906) > __request_handler: 14
11-23 14:29:22.458+0530 D/AUL_AMD (  593): amd_status.c: _status_app_is_running_from_cache(824) > is_running hit cache, return immediately
11-23 14:29:22.458+0530 D/AUL_AMD (  593): amd_request.c: __request_handler(1173) > [SECURE_LOG] APP_IS_RUNNING : org.example.iap-test : 1473
11-23 14:29:22.458+0530 W/AUL_AMD (  593): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 1473
11-23 14:29:22.458+0530 I/samsung-log-manager( 1342): SLogMgr_UseAppStatusMonitor.cpp: DbusSignalHandlerAppFw(233) > [SECURE_LOG] [(233)]: Background 1550 com.samsung.task-mgr
11-23 14:29:22.458+0530 I/samsung-log-manager( 1342): SLogMgr_NativeDbHelper.cpp: ExecQuery(180) > [SECURE_LOG] [(180)]: query tmp [INSERT INTO use_app_survey(app_id,duration,timestamp,time_zone) VALUES ('com.samsung.task-mgr',1593,1448269162460,'Asia/Kolkata');]
11-23 14:29:22.458+0530 W/AUL     ( 1550): launch.c: app_request_to_launchpad(396) > request cmd(4) to(1473)
11-23 14:29:22.458+0530 D/AUL     ( 1550): app_sock.c: __app_send_raw(288) > pid(-2) : cmd(4)
11-23 14:29:22.458+0530 W/AUL_AMD (  593): amd_request.c: __request_handler(906) > __request_handler: 4
11-23 14:29:22.458+0530 D/AUL_AMD (  593): amd_request.c: __app_process_by_pid(308) > [SECURE_LOG] __app_process_by_pid, pid: 1473, 
11-23 14:29:22.458+0530 D/AUL     (  593): app_sock.c: __app_send_raw_with_delay_reply(458) > pid(1473) : cmd(4)
11-23 14:29:22.458+0530 D/AUL_AMD (  593): amd_launch.c: _term_app(1237) > term done
11-23 14:29:22.458+0530 D/APP_CORE( 1473): appcore.c: __aul_handler(626) > [APP 1473]     AUL event: AUL_TERMINATE
11-23 14:29:22.458+0530 D/AUL_AMD (  593): amd_launch.c: __set_reply_handler(1186) > listen fd : 33, send fd : 32
11-23 14:29:22.458+0530 I/APP_CORE( 1473): appcore-efl.c: __do_app(514) > [APP 1473] Event: TERMINATE State: PAUSED
11-23 14:29:22.458+0530 D/APP_CORE( 1473): appcore-efl.c: __do_app(535) > [APP 1473] TERMINATE
11-23 14:29:22.458+0530 D/AUL     ( 1473): app_sock.c: __app_send_raw_with_noreply(387) > pid(-2) : cmd(22)
11-23 14:29:22.458+0530 W/AUL_AMD (  593): amd_launch.c: __reply_handler(1083) > listen fd(33) , send fd(32), pid(1473), cmd(4)
11-23 14:29:22.458+0530 W/AUL     ( 1550): launch.c: app_request_to_launchpad(425) > request cmd(4) result(0)
11-23 14:29:22.458+0530 D/TASK_MGR_LITE( 1550): recent_apps.c: kill_pid(93) > terminate pid = 1473
11-23 14:29:22.458+0530 D/RUA     ( 1550): rua.c: rua_delete_history_with_pkgname(91) > rua_delete_history_with_pkgname start
11-23 14:29:22.458+0530 D/RESOURCED(  709): cgroup.c: cgroup_write_node(133) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 1473
11-23 14:29:22.458+0530 W/AUL_AMD (  593): amd_request.c: __request_handler(906) > __request_handler: 22
11-23 14:29:22.458+0530 W/AUL_AMD (  593): amd_request.c: __request_handler(1201) > app status : 5
11-23 14:29:22.458+0530 D/AUL_AMD (  593): amd_status.c: _status_update_app_info_list(431) > pid(1473) status(5)
11-23 14:29:22.458+0530 D/AUL     ( 1473): app_sock.c: __app_send_raw_with_noreply(387) > pid(-2) : cmd(22)
11-23 14:29:22.458+0530 D/AUL_AMD (  593): amd_status.c: _status_update_app_info_list(442) > pid(1473) appid(org.example.iap-test) pkgid(org.example.iap-test) status(5)
11-23 14:29:22.458+0530 D/RESOURCED(  709): net-cls-cgroup.c: place_pids_to_net_cgroup(330) > /proc/1473/task/1473/children of org.example.iap-test is not existed
11-23 14:29:22.458+0530 D/RESOURCED(  709): cgroup.c: cgroup_write_node(133) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/net_cls/org.example.iap-test/cgroup.procs, value 1473
11-23 14:29:22.458+0530 D/RESOURCED(  709): freezer-process.c: freezer_process_pid_set(156) > freezer_process_pid_set 1473
11-23 14:29:22.458+0530 W/AUL_AMD (  593): amd_request.c: __request_handler(906) > __request_handler: 22
11-23 14:29:22.458+0530 W/AUL_AMD (  593): amd_request.c: __request_handler(1201) > app status : 5
11-23 14:29:22.458+0530 D/AUL_AMD (  593): amd_status.c: _status_update_app_info_list(431) > pid(1473) status(5)
11-23 14:29:22.458+0530 D/AUL_AMD (  593): amd_status.c: _status_update_app_info_list(442) > pid(1473) appid(org.example.iap-test) pkgid(org.example.iap-test) status(5)
11-23 14:29:22.458+0530 D/APP_CORE( 1473): appcore-efl.c: __check_skip(707) > ret(1), win(5800003), state(b7bc7c10), num(1)
11-23 14:29:22.458+0530 D/APP_CORE( 1473): appcore-efl.c: __check_skip(710) > state[0] : 9
11-23 14:29:22.468+0530 I/TIZEN_N_EFL_UTIL_WINDOW( 1473): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 10
11-23 14:29:22.468+0530 E/APP_CORE( 1473): appcore-efl.c: _capture_and_make_file(1619) > win[5800003] widget[720] height[1280]
11-23 14:29:22.468+0530 D/AUL     ( 1473): app_sock.c: __app_send_raw(288) > pid(-2) : cmd(33)
11-23 14:29:22.468+0530 W/AUL_AMD (  593): amd_request.c: __request_handler(906) > __request_handler: 33
11-23 14:29:22.468+0530 E/APP_CORE( 1473): appcore-efl.c: _capture_and_make_file(1622) > cannot a capture file for the package of [org.example.iap-test]
11-23 14:29:22.478+0530 I/CAPI_APPFW_APPLICATION( 1473): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
11-23 14:29:22.478+0530 D/RUA     ( 1550): rua.c: rua_delete_history_with_pkgname(124) > rua_delete_history_with_pkgname ok
11-23 14:29:22.478+0530 D/TASK_MGR_LITE( 1550): recent_apps.c: recent_apps_kill_selected(199) > End recent_apps_kill_selected, result: 
11-23 14:29:22.478+0530 D/TASK_MGR_LITE( 1550): capture_inotify.c: destroy_capture_inotify(148) > finish inotify of /opt/usr/share/app_capture
11-23 14:29:22.478+0530 E/TASK_MGR_LITE( 1550): recent_app_viewer.c: destroy_recent_app_viewer(1583) > destroy_recent_app_viewer
11-23 14:29:22.488+0530 D/TASK_MGR_LITE( 1550): recent_apps.c: recent_app_list_destroy(635) > recent_app_list_destroy
11-23 14:29:22.488+0530 D/TASK_MGR_LITE( 1550): recent_apps.c: list_destroy(374) > START list_destroy
11-23 14:29:22.488+0530 E/TASK_MGR_LITE( 1550): recent_apps.c: list_destroy(376) > (NULL == list) -> list_destroy() return
11-23 14:29:22.488+0530 D/TASK_MGR_LITE( 1550): recent_apps.c: list_destroy(374) > START list_destroy
11-23 14:29:22.488+0530 D/TASK_MGR_LITE( 1550): recent_apps.c: list_destroy(383) > Free: org.example.iap-test
11-23 14:29:22.488+0530 D/TASK_MGR_LITE( 1550): recent_apps.c: list_unretrieve_item(215) > Unretrieve app: iap-test (org.example.iap-test)
11-23 14:29:22.498+0530 E/APP_CORE( 1550): appcore.c: appcore_flush_memory(793) > Appcore not initialized
11-23 14:29:22.498+0530 D/UXT     ( 1550): uxt_theme.c: uxt_theme_delete_color_table(654) > color table (b8e1f698) is freed
11-23 14:29:22.498+0530 D/UXT     ( 1550): uxt_theme.c: uxt_theme_delete_font_table(1399) > color table (b9071498) is freed
11-23 14:29:22.498+0530 E/EFL     (  465): eo<465> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
11-23 14:29:22.508+0530 W/AUL_AMD (  593): amd_launch.c: __e17_status_handler(3328) > pid(1473) status(3)
11-23 14:29:22.518+0530 I/MALI    ( 1550): egl_platform_x11.c: __egl_platform_terminate(358) > [EGL-X11] PID=1550   close drm_fd=30 
11-23 14:29:22.708+0530 D/APP_CORE( 1550): appcore-efl.c: appcore_efl_main(1678) > [SECURE_LOG] [task-mgr:Application:Terminate]
11-23 14:29:22.729+0530 D/AUL_PAD ( 1472): launchpad.c: main(675) > pfds[LAUNCH_PAD].revent  : 0x0
11-23 14:29:22.729+0530 D/AUL_PAD ( 1472): launchpad.c: main(677) > pfds[POOL_TYPE + 0].revents : 0x0
11-23 14:29:22.729+0530 D/AUL_PAD ( 1472): launchpad.c: main(678) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
11-23 14:29:22.729+0530 D/AUL_PAD ( 1472): launchpad.c: main(677) > pfds[POOL_TYPE + 1].revents : 0x0
11-23 14:29:22.729+0530 D/AUL_PAD ( 1472): launchpad.c: main(678) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
11-23 14:29:22.729+0530 D/AUL_PAD ( 1472): launchpad.c: main(677) > pfds[POOL_TYPE + 2].revents : 0x0
11-23 14:29:22.729+0530 D/AUL_PAD ( 1472): launchpad.c: main(678) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
11-23 14:29:22.729+0530 I/AUL_PAD ( 1472): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 1550 pgid = 1550
11-23 14:29:22.729+0530 I/AUL_PAD ( 1472): sigchild.h: __sigchild_action(143) > dead_pid(1550)
11-23 14:29:22.759+0530 D/AUL_PAD ( 1472): sigchild.h: __send_app_dead_signal(91) > send dead signal done
11-23 14:29:22.759+0530 I/AUL_PAD ( 1472): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
11-23 14:29:22.759+0530 I/AUL_PAD ( 1472): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
11-23 14:29:22.759+0530 E/AUL_PAD ( 1472): launchpad.c: main(698) > error reading sigchld info
11-23 14:29:22.759+0530 D/STARTER (  761): lock-daemon-lite.c: lockd_app_dead_cb_lite(1158) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.53/src/lock-daemon-lite.c:1158:D] app dead cb call! (pid : 1550)
11-23 14:29:22.759+0530 I/ESD     (  974): esd_main.c: __esd_app_dead_handler(1773) > pid: 1550
11-23 14:29:22.759+0530 D/STARTER (  761): menu_daemon.c: menu_daemon_check_dead_signal(840) > [menu_daemon_check_dead_signal:840] Process 1550 is termianted
11-23 14:29:22.759+0530 I/Tizen::App( 1363): (243) > App[com.samsung.task-mgr] pid[1550] terminate event is forwarded
11-23 14:29:22.759+0530 I/Tizen::System( 1363): (256) > osp.accessorymanager.service provider is found.
11-23 14:29:22.759+0530 I/Tizen::System( 1363): (196) > Accessory Owner is removed [com.samsung.task-mgr, 1550, ]
11-23 14:29:22.759+0530 I/Tizen::System( 1363): (256) > osp.system.service provider is found.
11-23 14:29:22.759+0530 I/Tizen::App( 1363): (506) > TerminatedApp(com.samsung.task-mgr)
11-23 14:29:22.759+0530 I/Tizen::App( 1363): (512) > Not registered pid(1550)
11-23 14:29:22.759+0530 I/Tizen::System( 1363): (246) > Terminated app [com.samsung.task-mgr]
11-23 14:29:22.759+0530 D/STARTER (  761): menu_daemon.c: menu_daemon_check_dead_signal(893) > [menu_daemon_check_dead_signal:893] Unknown process, ignore it (dead pid 1550, home pid 870, taskmgr pid -1)
11-23 14:29:22.759+0530 I/Tizen::Io( 1363): (729) > Entry not found
11-23 14:29:22.759+0530 W/AUL_AMD (  593): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 1550
11-23 14:29:22.759+0530 W/AUL_AMD (  593): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 1550
11-23 14:29:22.759+0530 D/AUL_AMD (  593): amd_key.c: _unregister_key_event(179) > ===key stack===
11-23 14:29:22.759+0530 D/AUL_AMD (  593): amd_status.c: _status_publish_app_status(1132) > [SECURE_LOG] pid(1550) status(0)
11-23 14:29:22.759+0530 D/AUL_AMD (  593): amd_status.c: _status_publish_app_status(1139) > [SECURE_LOG] pid(1550) appid(com.samsung.task-mgr)
11-23 14:29:22.759+0530 D/AUL_AMD (  593): amd_launch.c: __amd_effect_image_file_set(1472) > [SECURE_LOG] path : com.samsung.task-mgr
11-23 14:29:22.759+0530 D/AUL_AMD (  593): amd_launch.c: __amd_send_message_to_e17(1506) > root win : 5a
11-23 14:29:22.759+0530 D/AUL_AMD (  593): amd_launch.c: __amd_send_message_to_e17(1521) > [LAUNCHING EFFECT]: message type(0), screen mode(0), effect type(-1), theme(0), indicator hide
11-23 14:29:22.759+0530 D/AUL_AMD (  593): amd_launch.c: __amd_send_message_to_e17(1528) > ecore_x_client_message32_send : 1
11-23 14:29:22.759+0530 D/AUL_AMD (  593): amd_status.c: _status_publish_app_status(1160) > [SECURE_LOG] appid(com.samsung.camera-app-lite)
11-23 14:29:22.759+0530 D/AUL_AMD (  593): amd_status.c: __remove_pkg_info(262) > ~STATUS_SERVICE : appid(com.samsung.task-mgr)
11-23 14:29:22.759+0530 D/AUL     (  593): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
11-23 14:29:22.759+0530 D/AUL     (  593): simple_util.c: __trm_app_info_send_socket(354) > send
11-23 14:29:22.759+0530 E/RESOURCED(  709): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.294
11-23 14:29:22.769+0530 D/RESOURCED(  709): proc-monitor.c: proc_dbus_aul_terminated(1119) > received terminated process : pid 1550
11-23 14:29:22.769+0530 I/Tizen::System( 1363): (157) > change brightness system value.
11-23 14:29:22.769+0530 I/Tizen::App( 1363): (782) > Finished invoking application event listener for com.samsung.task-mgr, 1550.
11-23 14:29:22.779+0530 D/RESOURCED(  709): appinfo-list.c: resourced_appinfo_put(132) > appid com.samsung.task-mgr, pkgname = com.samsung.task-mgr, ref = 0
11-23 14:29:22.779+0530 D/RESOURCED(  709): counter-process.c: _process_network_counter(1156) > There is no serialized counters in response
11-23 14:29:22.779+0530 D/RESOURCED(  709): counter-process.c: _process_network_counter(1156) > There is no serialized counters in response
11-23 14:29:22.779+0530 D/RESOURCED(  709): counter-process.c: _process_network_counter(1156) > There is no serialized counters in response
11-23 14:29:22.779+0530 D/RESOURCED(  709): counter-process.c: _process_network_counter(1156) > There is no serialized counters in response
11-23 14:29:23.429+0530 W/CRASH_MANAGER( 1702): worker.c: worker_job(1199) > 0601473696170144826916
