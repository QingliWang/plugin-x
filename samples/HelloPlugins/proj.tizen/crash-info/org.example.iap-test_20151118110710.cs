S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.2
Build-Number: Z300HDDE0BOK3
Build-Date: 2015.11.09 20:13:02

Crash Information
Process Name: iap-test
PID: 10115
Date: 2015-11-18 11:07:10+0530
Executable File Path: /opt/usr/apps/org.example.iap-test/bin/iap-test
Signal: 6
      (SIGABRT)
      si_code: -6
      signal sent by tkill (sent by pid 10115, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x00002783
r2   = 0x00000006, r3   = 0xb41134c0
r4   = 0x00000002, r5   = 0xb4113000
r6   = 0xb681409c, r7   = 0x0000010c
r8   = 0x00000001, r9   = 0x00000002
r10  = 0x00000007, fp   = 0xbe80e3c0
ip   = 0x00000000, sp   = 0xbe80e184
lr   = 0xb670af18, pc   = 0xb6709b84
cpsr = 0x200e0010

Memory Information
MemTotal:   986992 KB
MemFree:    114480 KB
Buffers:     35220 KB
Cached:     342188 KB
VmPeak:     134440 KB
VmSize:     127428 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       34788 KB
VmRSS:       31816 KB
VmData:      39676 KB
VmStk:         136 KB
VmExe:          24 KB
VmLib:       41384 KB
VmPTE:         100 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 10115 TID = 10115
10115 10116 10170 10175 

Maps Information
b0e18000 b1617000 rw-p [stack:10175]
b1617000 b1618000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1628000 b163c000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b16a0000 b1e9f000 rw-p [stack:10170]
b1e9f000 b1ffa000 r-xp /usr/lib/egl/libMali.so
b200f000 b2098000 r-xp /usr/lib/evas/modules/engines/gl_generic/v-1.13/module.so
b20b0000 b20ba000 r-xp /usr/lib/evas/modules/engines/gl_x11/v-1.13/module.so
b20cb000 b20d7000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b2419000 b2420000 r-xp /usr/lib/libefl-extension.so.0.1.0
b2431000 b2435000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.18
b2448000 b244e000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b245e000 b2801000 r-xp /opt/usr/apps/org.example.iap-test/bin/iap-test
b2970000 b2a53000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2a8a000 b2ab2000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2ac4000 b32c3000 rw-p [stack:10116]
b32c3000 b32c5000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b32d5000 b32df000 r-xp /lib/libnss_files-2.20-2014.11.so
b32f0000 b32f9000 r-xp /lib/libnss_nis-2.20-2014.11.so
b330a000 b331b000 r-xp /lib/libnsl-2.20-2014.11.so
b332e000 b3334000 r-xp /lib/libnss_compat-2.20-2014.11.so
b3345000 b3346000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b336e000 b3375000 r-xp /usr/lib/libminizip.so.1.0.0
b3385000 b338a000 r-xp /usr/lib/libstorage.so.0.1
b339a000 b340b000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b3421000 b3435000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b3445000 b3489000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b3499000 b34a1000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b34b1000 b34e1000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b34f4000 b35ad000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b35c1000 b3626000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b3637000 b3652000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b3662000 b3723000 r-xp /usr/lib/libprotobuf.so.9.0.1
b3736000 b3747000 r-xp /usr/lib/libefl-assist.so.0.1.0
b3757000 b3764000 r-xp /usr/lib/libmdm-common.so.1.0.97
b3775000 b377c000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b378c000 b37cd000 r-xp /usr/lib/libmdm.so.1.2.10
b37dd000 b37e5000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b37f4000 b3804000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b3825000 b3885000 r-xp /usr/lib/libasound.so.2.0.0
b3897000 b389a000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b38aa000 b38ad000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b38bd000 b38c2000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b38d2000 b38d3000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b38e3000 b38ee000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b3902000 b390b000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b391b000 b3923000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3933000 b3938000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3948000 b3964000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3975000 b397c000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b398c000 b3990000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b39a0000 b39ce000 r-xp /usr/lib/libidn.so.11.5.44
b39de000 b39f4000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3a05000 b3a0f000 r-xp /usr/lib/libcares.so.2.1.0
b3a1f000 b3a29000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.29
b3a39000 b3a3b000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b3a4b000 b3a4c000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3a5c000 b3a60000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3a71000 b3a9c000 r-xp /usr/lib/libui-extension.so.0.1.0
b3aac000 b3ad5000 r-xp /usr/lib/libturbojpeg.so
b3af5000 b3afb000 r-xp /usr/lib/libgif.so.4.1.6
b3b0b000 b3b51000 r-xp /usr/lib/libcurl.so.4.3.0
b3b62000 b3b83000 r-xp /usr/lib/libexif.so.12.3.3
b3b9e000 b3bb3000 r-xp /usr/lib/libtts.so
b3bc4000 b3bcc000 r-xp /usr/lib/libfeedback.so.0.1.4
b3bdd000 b3ca2000 r-xp /usr/lib/libdali-core.so.0.0.0
b3cc3000 b3dba000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3dda000 b3ea8000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3ebf000 b3ec1000 r-xp /usr/lib/libboost_system.so.1.51.0
b3ed1000 b3ed7000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3ee7000 b3f0a000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3f1b000 b3f1d000 r-xp /usr/lib/libappsvc.so.0.1.0
b3f2d000 b3f2f000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3f40000 b3f45000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3f5c000 b3f5e000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3f6e000 b3f75000 r-xp /usr/lib/libsensord-share.so
b3f85000 b3f9d000 r-xp /usr/lib/libsensor.so.1.1.0
b3fae000 b3fb1000 r-xp /usr/lib/libXv.so.1.0.0
b3fc1000 b3fc6000 r-xp /usr/lib/libutilX.so.1.1.0
b3fd6000 b3fdc000 r-xp /usr/lib/libappcore-common.so.1.1
b3fec000 b3ff3000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b4006000 b400a000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b401b000 b40f9000 r-xp /usr/lib/libCOREGL.so.4.0
b4119000 b411c000 r-xp /usr/lib/libuuid.so.1.3.0
b412c000 b4143000 r-xp /usr/lib/libblkid.so.1.1.0
b4154000 b4156000 r-xp /usr/lib/libXau.so.6.0.0
b4166000 b41ad000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b41bf000 b41c5000 r-xp /usr/lib/libjson-c.so.2.0.1
b41d6000 b41da000 r-xp /usr/lib/libogg.so.0.7.1
b41ea000 b420c000 r-xp /usr/lib/libvorbis.so.0.4.3
b421c000 b4300000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b431c000 b431f000 r-xp /usr/lib/libEGL.so.1.4
b4330000 b4336000 r-xp /usr/lib/libxcb-render.so.0.0.0
b4346000 b4348000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b4358000 b4365000 r-xp /usr/lib/libGLESv2.so.2.0
b4376000 b43d8000 r-xp /usr/lib/libpixman-1.so.0.28.2
b43ed000 b4405000 r-xp /usr/lib/libmount.so.1.1.0
b4417000 b442b000 r-xp /usr/lib/libxcb.so.1.1.0
b443b000 b4442000 r-xp /lib/libcrypt-2.20-2014.11.so
b447a000 b447c000 r-xp /usr/lib/libiri.so
b448c000 b4497000 r-xp /usr/lib/libgpg-error.so.0.15.0
b44a8000 b44de000 r-xp /usr/lib/libpulse.so.0.16.2
b44ef000 b4532000 r-xp /usr/lib/libsndfile.so.1.0.25
b4547000 b455c000 r-xp /lib/libexpat.so.1.5.2
b456e000 b462c000 r-xp /usr/lib/libcairo.so.2.11200.14
b4640000 b4648000 r-xp /usr/lib/libdrm.so.2.4.0
b4658000 b465b000 r-xp /usr/lib/libdri2.so.0.0.0
b466b000 b46b9000 r-xp /usr/lib/libssl.so.1.0.0
b46ce000 b46da000 r-xp /usr/lib/libeeze.so.1.13.0
b46eb000 b46f4000 r-xp /usr/lib/libethumb.so.1.13.0
b4704000 b4707000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b4717000 b48ce000 r-xp /usr/lib/libcrypto.so.1.0.0
b56b9000 b56c2000 r-xp /usr/lib/libXi.so.6.1.0
b56d2000 b56d4000 r-xp /usr/lib/libXgesture.so.7.0.0
b56e4000 b56e8000 r-xp /usr/lib/libXtst.so.6.1.0
b56f8000 b56fe000 r-xp /usr/lib/libXrender.so.1.3.0
b570e000 b5714000 r-xp /usr/lib/libXrandr.so.2.2.0
b5724000 b5726000 r-xp /usr/lib/libXinerama.so.1.0.0
b5737000 b573a000 r-xp /usr/lib/libXfixes.so.3.1.0
b574a000 b5755000 r-xp /usr/lib/libXext.so.6.4.0
b5765000 b5767000 r-xp /usr/lib/libXdamage.so.1.1.0
b5777000 b5779000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5789000 b586b000 r-xp /usr/lib/libX11.so.6.3.0
b587f000 b5886000 r-xp /usr/lib/libXcursor.so.1.0.2
b5896000 b58ae000 r-xp /usr/lib/libudev.so.1.6.0
b58b0000 b58b3000 r-xp /lib/libattr.so.1.1.0
b58c3000 b58e3000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b58e4000 b58e9000 r-xp /usr/lib/libffi.so.6.0.2
b58fa000 b5912000 r-xp /lib/libz.so.1.2.8
b5922000 b5924000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b5934000 b5a09000 r-xp /usr/lib/libxml2.so.2.9.2
b5a1e000 b5ab9000 r-xp /usr/lib/libstdc++.so.6.0.20
b5ad5000 b5ad8000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5ae8000 b5b07000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5b17000 b5b28000 r-xp /lib/libresolv-2.20-2014.11.so
b5b3c000 b5bb6000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5bcb000 b5bcd000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5bdd000 b5be4000 r-xp /usr/lib/libembryo.so.1.13.0
b5bf4000 b5bfe000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5c0f000 b5c27000 r-xp /usr/lib/libpng12.so.0.50.0
b5c38000 b5c5b000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c7c000 b5c90000 r-xp /usr/lib/libector.so.1.13.0
b5ca1000 b5cb9000 r-xp /usr/lib/liblua-5.1.so
b5cca000 b5d21000 r-xp /usr/lib/libfreetype.so.6.11.3
b5d35000 b5d5d000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d6e000 b5d81000 r-xp /usr/lib/libfribidi.so.0.3.1
b5d92000 b5dcc000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5ddd000 b5deb000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5dfb000 b5e03000 r-xp /usr/lib/libtbm.so.1.0.0
b5e13000 b5e20000 r-xp /usr/lib/libeio.so.1.13.0
b5e30000 b5e32000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5e42000 b5e47000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5e57000 b5e6e000 r-xp /usr/lib/libefreet.so.1.13.0
b5e80000 b5ea0000 r-xp /usr/lib/libeldbus.so.1.13.0
b5eb0000 b5ed0000 r-xp /usr/lib/libecore_con.so.1.13.0
b5ed2000 b5ed8000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5ee8000 b5ef9000 r-xp /usr/lib/libemotion.so.1.13.0
b5f0a000 b5f11000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5f21000 b5f30000 r-xp /usr/lib/libeo.so.1.13.0
b5f41000 b5f53000 r-xp /usr/lib/libecore_input.so.1.13.0
b5f64000 b5f69000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f79000 b5f92000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5fa2000 b5fbf000 r-xp /usr/lib/libeet.so.1.13.0
b5fd8000 b6020000 r-xp /usr/lib/libeina.so.1.13.0
b6031000 b6041000 r-xp /usr/lib/libefl.so.1.13.0
b6052000 b6137000 r-xp /usr/lib/libicuuc.so.51.1
b6154000 b6294000 r-xp /usr/lib/libicui18n.so.51.1
b62ab000 b62e3000 r-xp /usr/lib/libecore_x.so.1.13.0
b62f5000 b62f8000 r-xp /lib/libcap.so.2.21
b6308000 b6331000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6342000 b6349000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b635b000 b6392000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b63a3000 b648e000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b64a1000 b651a000 r-xp /usr/lib/libsqlite3.so.0.8.6
b652c000 b6531000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b6541000 b654c000 r-xp /usr/lib/libvconf.so.0.2.45
b655c000 b655e000 r-xp /usr/lib/libvasum.so.0.3.1
b656e000 b6570000 r-xp /usr/lib/libttrace.so.1.1
b6580000 b6583000 r-xp /usr/lib/libiniparser.so.0
b6593000 b65b9000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b65ca000 b65cf000 r-xp /usr/lib/libxdgmime.so.1.1.0
b65e0000 b65f7000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6608000 b6673000 r-xp /lib/libm-2.20-2014.11.so
b6684000 b668a000 r-xp /lib/librt-2.20-2014.11.so
b669b000 b66a8000 r-xp /usr/lib/libunwind.so.8.0.1
b66de000 b6802000 r-xp /lib/libc-2.20-2014.11.so
b6817000 b6830000 r-xp /lib/libgcc_s-4.9.so.1
b6840000 b6922000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b6933000 b695d000 r-xp /usr/lib/libdbus-1.so.3.8.12
b696e000 b69aa000 r-xp /usr/lib/libsystemd.so.0.4.0
b69ac000 b6a2f000 r-xp /usr/lib/libedje.so.1.13.0
b6a42000 b6a60000 r-xp /usr/lib/libecore.so.1.13.0
b6a80000 b6c08000 r-xp /usr/lib/libevas.so.1.13.0
b6c3d000 b6c51000 r-xp /lib/libpthread-2.20-2014.11.so
b6c65000 b6e99000 r-xp /usr/lib/libelementary.so.1.13.0
b6ec8000 b6ecc000 r-xp /usr/lib/libsmack.so.1.0.0
b6edc000 b6ee3000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6ef3000 b6ef5000 r-xp /usr/lib/libdlog.so.0.0.0
b6f05000 b6f08000 r-xp /usr/lib/libbundle.so.0.1.22
b6f18000 b6f1a000 r-xp /lib/libdl-2.20-2014.11.so
b6f2b000 b6f44000 r-xp /usr/lib/libaul.so.0.1.0
b6f57000 b6f5d000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f6f000 b6f7c000 r-xp /usr/lib/liblptcp.so
b6f8e000 b6f92000 r-xp /usr/lib/libsys-assert.so
b6fa3000 b6fc3000 r-xp /lib/ld-2.20-2014.11.so
b6fd4000 b6fda000 r-xp /usr/bin/launchpad-loader
b862a000 b8aa0000 rw-p [heap]
be7ee000 be80f000 rw-p [stack]
b6fd4000 b6fda000 r-xp /usr/bin/launchpad-loader
b862a000 b8aa0000 rw-p [heap]
be7ee000 be80f000 rw-p [stack]
End of Maps Information

Callstack Information (PID:10115)
Call Stack Count: 15
 0: gsignal + 0x34 (0xb6709b84) [/lib/libc.so.6] + 0x2bb84
 1: abort + 0x12c (0xb670af18) [/lib/libc.so.6] + 0x2cf18
 2: (0xb674546c) [/lib/libc.so.6] + 0x6746c
 3: (0xb674b0d4) [/lib/libc.so.6] + 0x6d0d4
 4: (0xb674ba5c) [/lib/libc.so.6] + 0x6da5c
 5: _ZN11AppDelegateD0Ev + 0x14 (0xb249aead) [/opt/usr/apps/org.example.iap-test/bin/iap-test] + 0x3cead
 6: _ZN7cocos2dL13app_terminateEPv + 0x2a (0xb24f47c3) [/opt/usr/apps/org.example.iap-test/bin/iap-test] + 0x967c3
 7: (0xb4008589) [/usr/lib/libcapi-appfw-application.so.0] + 0x2589
 8: appcore_efl_main + 0x43a (0xb6f5ad3f) [/usr/lib/libappcore-efl.so.1] + 0x3d3f
 9: ui_app_main + 0xc0 (0xb4008909) [/usr/lib/libcapi-appfw-application.so.0] + 0x2909
10: _ZN7cocos2d11Application3runEv + 0x60 (0xb24f483d) [/opt/usr/apps/org.example.iap-test/bin/iap-test] + 0x9683d
11: main + 0x32 (0xb248d8b3) [/opt/usr/apps/org.example.iap-test/bin/iap-test] + 0x2f8b3
12: (0xb6fd5ccf) [/opt/usr/apps/org.example.iap-test/bin/iap-test] + 0x1ccf
13: __libc_start_main + 0x114 (0xb66f44bc) [/lib/libc.so.6] + 0x164bc
14: (0xb6fd6114) [/opt/usr/apps/org.example.iap-test/bin/iap-test] + 0x2114
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
CED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 1
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 1
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:03:57.374+0530 D/RESOURCED(  667): datausage-common.c: del_counter_delayed(1772) > nfacct counter state is 0
11-18 11:04:01.018+0530 D/RESOURCED(  667): counter-process.c: check_net_blocked(99) > net_blocked 0, state 0
11-18 11:04:01.018+0530 D/RESOURCED(  667): app-stat.c: fill_nfacct_result(234) > cnt_name c4_2_0_wlan0
11-18 11:04:01.018+0530 D/RESOURCED(  667): app-stat.c: fill_nfacct_result(242) > classid 0, iftype 2, iotype 4, intend 0, ifname wlan0, bytes 324
11-18 11:04:01.018+0530 D/RESOURCED(  667): net-cls-cgroup.c: get_app_id_by_classid(293) > can't resolve app id
11-18 11:04:07.074+0530 I/tizenstore(10218): iap_update_engine.c: EngineEcoreIdlerCb(253) > Delay CHECK CACHE SPACE
11-18 11:04:17.074+0530 I/tizenstore(10218): iap_update_engine.c: EngineEcoreIdlerCb(253) > Delay CHECK CACHE SPACE
11-18 11:04:19.416+0530 D/RESOURCED(  667): logging.c: logging_send_signal_to_data(1072) > logging timer callback function start
11-18 11:04:19.416+0530 D/RESOURCED(  667): logging.c: logging_send_signal_to_data(1081) > send signal to logging data thread
11-18 11:04:19.416+0530 D/RESOURCED(  667): logging.c: logging_send_signal_to_update(1152) > logging timer callback function start
11-18 11:04:19.416+0530 D/RESOURCED(  667): logging.c: logging_send_signal_to_update(1161) > send signal to logging update thread
11-18 11:04:21.007+0530 D/RESOURCED(  667): counter-process.c: check_net_blocked(99) > net_blocked 0, state 0
11-18 11:04:27.063+0530 I/tizenstore(10218): iap_update_engine.c: EngineEcoreIdlerCb(253) > Delay CHECK CACHE SPACE
11-18 11:04:37.073+0530 I/tizenstore(10218): iap_update_engine.c: EngineEcoreIdlerCb(253) > Delay CHECK CACHE SPACE
11-18 11:04:41.017+0530 D/RESOURCED(  667): counter-process.c: check_net_blocked(99) > net_blocked 0, state 0
11-18 11:04:41.017+0530 D/RESOURCED(  667): specific-trace.c: print_appstat(54) > [SECURE_LOG] appid (null), rcv 810, snd 0, classid 0, iftype 2, ifname wlan0, is_roaming 2, ground 2
11-18 11:04:41.017+0530 D/RESOURCED(  667): datausage-vconf-callbacks.c: datausage_timer_change_cb(89) > [SECURE_LOG] key = db/resourced/datausage_timer, value = 548(int)
11-18 11:04:41.017+0530 D/RESOURCED(  667): counter-process.c: _process_network_counter(1156) > There is no serialized counters in response
11-18 11:04:41.017+0530 D/RESOURCED(  667): counter-process.c: _process_network_counter(1156) > There is no serialized counters in response
11-18 11:04:41.017+0530 D/RESOURCED(  667): counter-process.c: _process_network_counter(1156) > There is no serialized counters in response
11-18 11:04:41.017+0530 D/RESOURCED(  667): counter-process.c: _process_network_counter(1156) > There is no serialized counters in response
11-18 11:04:47.073+0530 I/tizenstore(10218): iap_update_engine.c: EngineEcoreIdlerCb(253) > Delay CHECK CACHE SPACE
11-18 11:04:57.063+0530 I/tizenstore(10218): iap_update_engine.c: EngineEcoreIdlerCb(253) > Delay CHECK CACHE SPACE
11-18 11:05:01.016+0530 D/RESOURCED(  667): counter-process.c: check_net_blocked(99) > net_blocked 0, state 0
11-18 11:05:01.016+0530 D/RESOURCED(  667): counter-process.c: _process_network_counter(1156) > There is no serialized counters in response
11-18 11:05:01.016+0530 D/RESOURCED(  667): counter-process.c: _process_network_counter(1156) > There is no serialized counters in response
11-18 11:05:01.016+0530 D/RESOURCED(  667): counter-process.c: _process_network_counter(1156) > There is no serialized counters in response
11-18 11:05:01.016+0530 D/RESOURCED(  667): counter-process.c: _process_network_counter(1156) > There is no serialized counters in response
11-18 11:05:01.016+0530 D/RESOURCED(  667): counter-process.c: _process_network_counter(1156) > There is no serialized counters in response
11-18 11:05:01.016+0530 D/RESOURCED(  667): counter-process.c: _process_network_counter(1156) > There is no serialized counters in response
11-18 11:05:07.062+0530 I/tizenstore(10218): iap_update_engine.c: EngineEcoreIdlerCb(253) > Delay CHECK CACHE SPACE
11-18 11:05:17.072+0530 I/tizenstore(10218): iap_update_engine.c: EngineEcoreIdlerCb(253) > Delay CHECK CACHE SPACE
11-18 11:05:19.414+0530 D/RESOURCED(  667): logging.c: logging_send_signal_to_data(1072) > logging timer callback function start
11-18 11:05:19.414+0530 D/RESOURCED(  667): logging.c: logging_send_signal_to_data(1081) > send signal to logging data thread
11-18 11:05:19.414+0530 D/RESOURCED(  667): logging.c: logging_send_signal_to_update(1152) > logging timer callback function start
11-18 11:05:19.414+0530 D/RESOURCED(  667): logging.c: logging_send_signal_to_update(1161) > send signal to logging update thread
11-18 11:05:21.006+0530 D/RESOURCED(  667): counter-process.c: check_net_blocked(99) > net_blocked 0, state 0
11-18 11:05:21.006+0530 D/RESOURCED(  667): counter-process.c: _process_network_counter(1156) > There is no serialized counters in response
11-18 11:05:21.006+0530 D/RESOURCED(  667): counter-process.c: _process_network_counter(1156) > There is no serialized counters in response
11-18 11:05:21.006+0530 D/RESOURCED(  667): counter-process.c: _process_network_counter(1156) > There is no serialized counters in response
11-18 11:05:21.006+0530 D/RESOURCED(  667): counter-process.c: _process_network_counter(1156) > There is no serialized counters in response
11-18 11:05:21.006+0530 D/RESOURCED(  667): counter-process.c: _process_network_counter(1156) > There is no serialized counters in response
11-18 11:05:21.006+0530 D/RESOURCED(  667): counter-process.c: _process_network_counter(1156) > There is no serialized counters in response
11-18 11:05:27.072+0530 I/tizenstore(10218): iap_update_engine.c: EngineEcoreIdlerCb(253) > Delay CHECK CACHE SPACE
11-18 11:05:37.072+0530 I/tizenstore(10218): iap_update_engine.c: EngineEcoreIdlerCb(253) > Delay CHECK CACHE SPACE
11-18 11:05:41.025+0530 D/RESOURCED(  667): counter-process.c: check_net_blocked(99) > net_blocked 0, state 0
11-18 11:05:41.025+0530 D/RESOURCED(  667): counter-process.c: _process_network_counter(1156) > There is no serialized counters in response
11-18 11:05:41.025+0530 D/RESOURCED(  667): counter-process.c: _process_network_counter(1156) > There is no serialized counters in response
11-18 11:05:41.025+0530 D/RESOURCED(  667): counter-process.c: _process_network_counter(1156) > There is no serialized counters in response
11-18 11:05:41.025+0530 D/RESOURCED(  667): counter-process.c: _process_network_counter(1156) > There is no serialized counters in response
11-18 11:05:41.025+0530 D/RESOURCED(  667): counter-process.c: _process_network_counter(1156) > There is no serialized counters in response
11-18 11:05:41.025+0530 D/RESOURCED(  667): counter-process.c: _process_network_counter(1156) > There is no serialized counters in response
11-18 11:05:47.071+0530 I/tizenstore(10218): iap_update_engine.c: EngineEcoreIdlerCb(253) > Delay CHECK CACHE SPACE
11-18 11:05:57.071+0530 I/tizenstore(10218): iap_update_engine.c: EngineEcoreIdlerCb(253) > Delay CHECK CACHE SPACE
11-18 11:06:01.015+0530 D/RESOURCED(  667): counter-process.c: check_net_blocked(99) > net_blocked 0, state 0
11-18 11:06:01.015+0530 D/RESOURCED(  667): counter-process.c: _process_network_counter(1156) > There is no serialized counters in response
11-18 11:06:01.015+0530 D/RESOURCED(  667): counter-process.c: _process_network_counter(1156) > There is no serialized counters in response
11-18 11:06:01.015+0530 D/RESOURCED(  667): counter-process.c: _process_network_counter(1156) > There is no serialized counters in response
11-18 11:06:01.015+0530 D/RESOURCED(  667): counter-process.c: _process_network_counter(1156) > There is no serialized counters in response
11-18 11:06:01.015+0530 D/RESOURCED(  667): counter-process.c: _process_network_counter(1156) > There is no serialized counters in response
11-18 11:06:01.015+0530 D/RESOURCED(  667): counter-process.c: _process_network_counter(1156) > There is no serialized counters in response
11-18 11:06:07.061+0530 I/tizenstore(10218): iap_update_engine.c: EngineEcoreIdlerCb(253) > Delay CHECK CACHE SPACE
11-18 11:06:17.071+0530 I/tizenstore(10218): iap_update_engine.c: EngineEcoreIdlerCb(253) > Delay CHECK CACHE SPACE
11-18 11:06:19.413+0530 D/RESOURCED(  667): logging.c: logging_send_signal_to_data(1072) > logging timer callback function start
11-18 11:06:19.413+0530 D/RESOURCED(  667): logging.c: logging_send_signal_to_data(1081) > send signal to logging data thread
11-18 11:06:19.413+0530 D/RESOURCED(  667): logging.c: logging_send_signal_to_update(1152) > logging timer callback function start
11-18 11:06:19.413+0530 D/RESOURCED(  667): logging.c: logging_send_signal_to_update(1161) > send signal to logging update thread
11-18 11:06:21.004+0530 D/RESOURCED(  667): counter-process.c: check_net_blocked(99) > net_blocked 0, state 0
11-18 11:06:21.004+0530 D/RESOURCED(  667): counter-process.c: _process_network_counter(1156) > There is no serialized counters in response
11-18 11:06:21.004+0530 D/RESOURCED(  667): counter-process.c: _process_network_counter(1156) > There is no serialized counters in response
11-18 11:06:21.004+0530 D/RESOURCED(  667): counter-process.c: _process_network_counter(1156) > There is no serialized counters in response
11-18 11:06:21.004+0530 D/RESOURCED(  667): counter-process.c: _process_network_counter(1156) > There is no serialized counters in response
11-18 11:06:21.004+0530 D/RESOURCED(  667): counter-process.c: _process_network_counter(1156) > There is no serialized counters in response
11-18 11:06:21.004+0530 D/RESOURCED(  667): counter-process.c: _process_network_counter(1156) > There is no serialized counters in response
11-18 11:06:27.060+0530 I/tizenstore(10218): iap_update_engine.c: EngineEcoreIdlerCb(253) > Delay CHECK CACHE SPACE
11-18 11:06:37.070+0530 I/tizenstore(10218): iap_update_engine.c: EngineEcoreIdlerCb(253) > Delay CHECK CACHE SPACE
11-18 11:06:41.014+0530 D/RESOURCED(  667): counter-process.c: check_net_blocked(99) > net_blocked 0, state 0
11-18 11:06:41.014+0530 D/RESOURCED(  667): counter-process.c: _process_network_counter(1156) > There is no serialized counters in response
11-18 11:06:41.014+0530 D/RESOURCED(  667): counter-process.c: _process_network_counter(1156) > There is no serialized counters in response
11-18 11:06:41.014+0530 D/RESOURCED(  667): counter-process.c: _process_network_counter(1156) > There is no serialized counters in response
11-18 11:06:41.014+0530 D/RESOURCED(  667): counter-process.c: _process_network_counter(1156) > There is no serialized counters in response
11-18 11:06:41.014+0530 D/RESOURCED(  667): counter-process.c: _process_network_counter(1156) > There is no serialized counters in response
11-18 11:06:41.014+0530 D/RESOURCED(  667): counter-process.c: _process_network_counter(1156) > There is no serialized counters in response
11-18 11:06:43.647+0530 W/LOCKSCREEN( 2084): property.c: _vconf_cb(228) > [_vconf_cb:228:W] property 200 is changed to 81
11-18 11:06:43.647+0530 W/LOCKSCREEN( 2084): daemon.c: lockd_event(1014) > [lockd_event:1014:W] event:40000:CONF_CHANGED
11-18 11:06:43.647+0530 W/LOCKSCREEN( 2084): daemon.c: _event_route(824) > [_event_route:824:W] event:40000 event_info:200
11-18 11:06:43.647+0530 W/LOCKSCREEN( 2084): view-mgr.c: _event_route(130) > [_event_route:130:W] event:40000 event_info:200
11-18 11:06:43.647+0530 D/LOCKSCREEN( 2084): battery.c: _view_update(150) > [_view_update:150] charging : Charging: 81%
11-18 11:06:43.647+0530 D/LOCKSCREEN( 2084): battery.c: _battery_label_text_set(97) > [_battery_label_text_set:97] type(2) text(Charging: 81%)
11-18 11:06:43.647+0530 D/LOCKSCREEN( 2084): battery.c: _property_changed(326) > [_property_changed:326] TA connected
11-18 11:06:43.657+0530 D/RESOURCED(  667): heart-battery.c: heart_battery_add_capacity(1168) > 80 -> 81 1447825003 210
11-18 11:06:43.657+0530 D/RESOURCED(  667): heart-battery.c: heart_battery_calculate_prediction(1137) > TimeToFull: 81 236 72 75
11-18 11:06:43.657+0530 D/RESOURCED(  667): heart-battery.c: heart_battery_calculate_prediction(1137) > TimeToFull: 81 0 0 74
11-18 11:06:43.657+0530 D/RESOURCED(  667): heart-battery.c: heart_battery_calculate_prediction(1137) > TimeToFull: 81 224 71 71
11-18 11:06:43.657+0530 D/RESOURCED(  667): heart-battery.c: heart_battery_calculate_prediction(1137) > TimeToFull: 81 0 0 0
11-18 11:06:43.657+0530 D/RESOURCED(  667): heart-battery.c: heart_battery_calculate_prediction(1137) > TimeToFull: 81 0 0 0
11-18 11:06:43.657+0530 D/RESOURCED(  667): heart-battery.c: heart_battery_add_capacity(1256) > battery_heart_capacity_write 81 diff_capacity 1, used time 0, charging time 210, charger status 1, reset_mark 0
11-18 11:06:43.657+0530 D/RESOURCED(  667): logging.c: logging_leveldb_putv(527) > BATTERY_USED_TIME:97972 516785 
11-18 11:06:43.657+0530 D/INDICATOR(  660): battery.c: indicator_battery_change_cb(685) > 
11-18 11:06:43.657+0530 E/INDICATOR(  660): battery.c: indicator_battery_update_display(598) > indicator_battery_update_display[598]	 ""
11-18 11:06:47.070+0530 I/tizenstore(10218): iap_update_engine.c: EngineEcoreIdlerCb(253) > Delay CHECK CACHE SPACE
11-18 11:06:57.070+0530 I/tizenstore(10218): iap_update_engine.c: EngineEcoreIdlerCb(253) > Delay CHECK CACHE SPACE
11-18 11:07:01.024+0530 D/RESOURCED(  667): counter-process.c: check_net_blocked(99) > net_blocked 0, state 0
11-18 11:07:01.024+0530 D/RESOURCED(  667): counter-process.c: _process_network_counter(1156) > There is no serialized counters in response
11-18 11:07:01.024+0530 D/RESOURCED(  667): counter-process.c: _process_network_counter(1156) > There is no serialized counters in response
11-18 11:07:01.024+0530 D/RESOURCED(  667): counter-process.c: _process_network_counter(1156) > There is no serialized counters in response
11-18 11:07:01.024+0530 D/RESOURCED(  667): counter-process.c: _process_network_counter(1156) > There is no serialized counters in response
11-18 11:07:01.024+0530 D/RESOURCED(  667): counter-process.c: _process_network_counter(1156) > There is no serialized counters in response
11-18 11:07:01.024+0530 D/RESOURCED(  667): counter-process.c: _process_network_counter(1156) > There is no serialized counters in response
11-18 11:07:07.069+0530 I/tizenstore(10218): iap_update_engine.c: EngineEcoreIdlerCb(253) > Delay CHECK CACHE SPACE
11-18 11:07:10.202+0530 E/PKGMGR_SERVER(10498): pkgmgr-server.c: main(2414) > package manager server start
11-18 11:07:10.202+0530 D/PKGMGR  (10498): comm_pkg_mgr_server.c: pkg_mgr_server_gdbus_init(421) > initialize_gdbus Enter
11-18 11:07:10.202+0530 D/PKGMGR  (10498): comm_pkg_mgr_server.c: pkg_mgr_server_gdbus_init(439) > initialize_gdbus Exit
11-18 11:07:10.243+0530 D/PKGMGR  (10498): comm_pkg_mgr_server.c: on_bus_acquired(391) > on_bus_acquired
11-18 11:07:10.243+0530 D/PKGMGR  (10498): comm_pkg_mgr_server.c: on_bus_acquired(416) > on_bus_acquired done
11-18 11:07:10.273+0530 D/PKGMGR  (10498): comm_pkg_mgr_server.c: pkgmgr_request(152) > Called
11-18 11:07:10.273+0530 D/PKGMGR  (10498): comm_pkg_mgr_server.c: pkgmgr_request(171) > sender_name: :1.1242
11-18 11:07:10.273+0530 D/PKGMGR  (10498): comm_pkg_mgr_server.c: pkg_mgr_get_sender_pid(80) > zone pid : 10496
11-18 11:07:10.273+0530 D/PKGMGR  (10498): comm_pkg_mgr_server.c: pkgmgr_request(173) > sender_pid: 10496
11-18 11:07:10.273+0530 D/PKGMGR  (10498): comm_pkg_mgr_server.c: pkgmgr_request(182) > [SECURE_LOG] Call request callback(obj, org.example.iap-test_144590123, 14, tpk, org.example.iap-test, , host)
11-18 11:07:10.273+0530 D/PKGMGR_SERVER(10498): pkgmgr-server.c: req_cb(630) > [SECURE_LOG] >> in callback >> Got request: [org.example.iap-test_144590123] [14] [tpk] [org.example.iap-test] [] [] [host]
11-18 11:07:10.273+0530 D/PKGMGR_SERVER(10498): pkgmgr-server.c: req_cb(651) > req_type=(14)  backend_flag=(0) zone(host)
11-18 11:07:10.283+0530 D/PKGMGR_SERVER(10498): pkgmgr-server.c: queue_job(2036) > target zone(host, host)
11-18 11:07:10.283+0530 D/PKGMGR_SERVER(10498): pkgmgr-server.c: queue_job(2040) > child forked [10501] for request type [14]
11-18 11:07:10.283+0530 D/PKGMGR_SERVER(10498): pkgmgr-server.c: queue_job(2331) > parent exit
11-18 11:07:10.283+0530 D/PKGMGR  (10496): pkgmgr.c: __check_sync_process(872) > file is not generated yet.... wait
11-18 11:07:10.283+0530 D/PKGMGR_SERVER(10501): pkgmgr-server.c: queue_job(2040) > child forked [0] for request type [14]
11-18 11:07:10.283+0530 D/PKGMGR_SERVER(10501): pkgmgr-server.c: queue_job(2226) > kill/check request
11-18 11:07:10.303+0530 D/PKGMGR_SERVER(10501): pkgmgr-server.c: __pkgcmd_app_cb(1599) > sub_cmd(kill), zone_name(host)
11-18 11:07:10.323+0530 D/AUL     (10501): app_sock.c: __app_send_raw(288) > pid(-2) : cmd(14)
11-18 11:07:10.323+0530 W/AUL_AMD (  608): amd_request.c: __request_handler(906) > __request_handler: 14
11-18 11:07:10.323+0530 D/AUL_AMD (  608): amd_status.c: _status_app_is_running_from_cache(824) > is_running hit cache, return immediately
11-18 11:07:10.323+0530 D/AUL_AMD (  608): amd_request.c: __request_handler(1173) > [SECURE_LOG] APP_IS_RUNNING : org.example.iap-test : 10115
11-18 11:07:10.323+0530 W/AUL_AMD (  608): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 10115
11-18 11:07:10.333+0530 W/AUL_AMD (  608): amd_request.c: __request_handler(906) > __request_handler: 12
11-18 11:07:10.333+0530 D/AUL     (10501): app_sock.c: __app_send_cmd_with_result(646) > recv result  = 1074
11-18 11:07:10.333+0530 W/AUL     (10501): launch.c: app_request_to_launchpad(396) > request cmd(5) to(10115)
11-18 11:07:10.333+0530 D/AUL     (10501): app_sock.c: __app_send_raw(288) > pid(-2) : cmd(5)
11-18 11:07:10.333+0530 W/AUL_AMD (  608): amd_request.c: __request_handler(906) > __request_handler: 5
11-18 11:07:10.333+0530 D/AUL_AMD (  608): amd_appinfo.c: appinfo_set_value(1320) > [SECURE_LOG] org.example.iap-test : installed : norestart
11-18 11:07:10.333+0530 D/AUL_AMD (  608): amd_request.c: __app_process_by_pid(308) > [SECURE_LOG] __app_process_by_pid, pid: 10115, 
11-18 11:07:10.333+0530 D/AUL     (  608): app_sock.c: __app_send_raw_with_delay_reply(458) > pid(10115) : cmd(4)
11-18 11:07:10.333+0530 D/AUL_AMD (  608): amd_launch.c: _term_app(1237) > term done
11-18 11:07:10.333+0530 D/AUL_AMD (  608): amd_launch.c: __set_reply_handler(1186) > listen fd : 38, send fd : 37
11-18 11:07:10.333+0530 D/RESOURCED(  667): cgroup.c: cgroup_write_node(133) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 10115
11-18 11:07:10.333+0530 D/RESOURCED(  667): net-cls-cgroup.c: place_pids_to_net_cgroup(330) > /proc/10115/task/10115/children of org.example.iap-test is not existed
11-18 11:07:10.333+0530 D/RESOURCED(  667): cgroup.c: cgroup_write_node(133) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/net_cls/org.example.iap-test/cgroup.procs, value 10115
11-18 11:07:10.333+0530 D/RESOURCED(  667): freezer-process.c: freezer_process_pid_set(156) > freezer_process_pid_set 10115
11-18 11:07:10.333+0530 D/RESOURCED(  667): cgroup.c: cgroup_write_node(133) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/freezer/thawed/cgroup.procs, value 10115
11-18 11:07:10.333+0530 W/AUL_AMD (  608): amd_launch.c: __reply_handler(1083) > listen fd(38) , send fd(37), pid(10115), cmd(4)
11-18 11:07:10.333+0530 W/AUL     (10501): launch.c: app_request_to_launchpad(425) > request cmd(5) result(0)
11-18 11:07:10.333+0530 D/AUL     (10501): app_sock.c: __app_send_raw(288) > pid(-2) : cmd(14)
11-18 11:07:10.333+0530 W/AUL_AMD (  608): amd_request.c: __request_handler(906) > __request_handler: 14
11-18 11:07:10.333+0530 D/AUL_AMD (  608): amd_status.c: _status_app_is_running_from_cache(824) > is_running hit cache, return immediately
11-18 11:07:10.333+0530 D/AUL_AMD (  608): amd_request.c: __request_handler(1173) > [SECURE_LOG] APP_IS_RUNNING : org.example.iap-test : 10115
11-18 11:07:10.333+0530 W/AUL_AMD (  608): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 10115
11-18 11:07:10.343+0530 D/APP_CORE(10115): appcore.c: __aul_handler(626) > [APP 10115]     AUL event: AUL_TERMINATE
11-18 11:07:10.343+0530 I/APP_CORE(10115): appcore-efl.c: __do_app(514) > [APP 10115] Event: TERMINATE State: PAUSED
11-18 11:07:10.343+0530 D/APP_CORE(10115): appcore-efl.c: __do_app(535) > [APP 10115] TERMINATE
11-18 11:07:10.343+0530 D/AUL     (10115): app_sock.c: __app_send_raw_with_noreply(387) > pid(-2) : cmd(22)
11-18 11:07:10.343+0530 W/AUL_AMD (  608): amd_request.c: __request_handler(906) > __request_handler: 22
11-18 11:07:10.343+0530 W/AUL_AMD (  608): amd_request.c: __request_handler(1201) > app status : 5
11-18 11:07:10.343+0530 D/AUL_AMD (  608): amd_status.c: _status_update_app_info_list(431) > pid(10115) status(5)
11-18 11:07:10.343+0530 D/AUL_AMD (  608): amd_status.c: _status_update_app_info_list(442) > pid(10115) appid(org.example.iap-test) pkgid(org.example.iap-test) status(5)
11-18 11:07:10.343+0530 D/AUL     (10115): app_sock.c: __app_send_raw_with_noreply(387) > pid(-2) : cmd(22)
11-18 11:07:10.343+0530 W/AUL_AMD (  608): amd_request.c: __request_handler(906) > __request_handler: 22
11-18 11:07:10.343+0530 W/AUL_AMD (  608): amd_request.c: __request_handler(1201) > app status : 5
11-18 11:07:10.343+0530 D/AUL_AMD (  608): amd_status.c: _status_update_app_info_list(431) > pid(10115) status(5)
11-18 11:07:10.343+0530 D/AUL_AMD (  608): amd_status.c: _status_update_app_info_list(442) > pid(10115) appid(org.example.iap-test) pkgid(org.example.iap-test) status(5)
11-18 11:07:10.343+0530 D/APP_CORE(10115): appcore-efl.c: __check_skip(707) > ret(1), win(2000003), state(b8967fc0), num(1)
11-18 11:07:10.343+0530 D/APP_CORE(10115): appcore-efl.c: __check_skip(710) > state[0] : 9
11-18 11:07:10.353+0530 I/TIZEN_N_EFL_UTIL_WINDOW(10115): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 11
11-18 11:07:10.353+0530 E/APP_CORE(10115): appcore-efl.c: _capture_and_make_file(1619) > win[2000003] widget[720] height[1280]
11-18 11:07:10.353+0530 D/AUL     (10115): app_sock.c: __app_send_raw(288) > pid(-2) : cmd(33)
11-18 11:07:10.353+0530 W/AUL_AMD (  608): amd_request.c: __request_handler(906) > __request_handler: 33
11-18 11:07:10.353+0530 E/APP_CORE(10115): appcore-efl.c: _capture_and_make_file(1622) > cannot a capture file for the package of [org.example.iap-test]
11-18 11:07:10.353+0530 I/CAPI_APPFW_APPLICATION(10115): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
11-18 11:07:10.383+0530 D/PKGMGR  (10496): pkgmgr.c: __check_sync_process(872) > file is not generated yet.... wait
11-18 11:07:10.443+0530 D/AUL     (10501): app_sock.c: __app_send_raw(288) > pid(-2) : cmd(14)
11-18 11:07:10.443+0530 W/AUL_AMD (  608): amd_request.c: __request_handler(906) > __request_handler: 14
11-18 11:07:10.443+0530 D/AUL_AMD (  608): amd_status.c: _status_app_is_running_from_cache(824) > is_running hit cache, return immediately
11-18 11:07:10.443+0530 D/AUL_AMD (  608): amd_request.c: __request_handler(1173) > [SECURE_LOG] APP_IS_RUNNING : org.example.iap-test : 10115
11-18 11:07:10.443+0530 D/AUL_AMD (  608): amd_request.c: __request_handler(1175) > [SECURE_LOG] APP_IS_RUNNING: 10115 is dying
11-18 11:07:10.443+0530 W/AUL_AMD (  608): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
11-18 11:07:10.443+0530 D/PKGMGR_SERVER(10501): pkgmgr-server.c: __make_pid_info_file(1525) > cano_path(tmp/org.example.iap-test)
11-18 11:07:10.443+0530 D/PKGMGR_SERVER(10501): pkgmgr-server.c: __make_pid_info_file(1544) > security_server_label_access(tmp/org.example.iap-test, *) is ok.
11-18 11:07:10.463+0530 D/PKGMGR_SERVER(10498): pkgmgr-server.c: sighandler(402) > child exit [10501]
11-18 11:07:10.463+0530 E/PKGMGR_SERVER(10498): pkgmgr-server.c: sighandler(417) > child NORMAL exit [10501]
11-18 11:07:10.483+0530 D/PKGMGR  (10496): pkgmgr.c: __check_sync_process(867) > info_file file is generated, result = 0
11-18 11:07:10.483+0530 D/PKGMGR  (10496): . 
11-18 11:07:10.483+0530 E/PKGMGR  (10496): pkgmgr.c: __check_sync_process(883) > file is can not remove[/tmp/org.example.iap-test, -1]
11-18 11:07:11.444+0530 W/CRASH_MANAGER(10505): worker.c: worker_job(1199) > 0610115696170144782503
