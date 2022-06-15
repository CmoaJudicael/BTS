var art = new Artplayer({
    container: '.artplayer-app',
    url: 'https://artplayer.org/assets/sample/video.mp4',
    title: 'One More Time One More Chance',
    volume: 0.5,
    isLive: false,
    muted: false,
    autoplay: false,
    pip: false,
    autoSize: true,
    autoMini: false,
    screenshot: false,
    setting: false,
    loop: true,
    flip: false,
    rotate: false,
    playbackRate: false,
    aspectRatio: false,
    fullscreen: false,
    fullscreenWeb: false,
    subtitleOffset: false,
    miniProgressBar: false,
    localVideo: false,
    localSubtitle: false,
    mutex: true,
    backdrop: false,
    theme: '#28283A',
    lang: navigator.language.toLowerCase(),
    moreVideoAttr: {
        crossOrigin: 'anonymous',
    },
    settings: [
        {
            index: 1,
            html: 'Custom setting',
            click: function (setting) {
                console.info('You clicked on the custom setting');
                setting.show = false;
            },
        },
    ],
    highlight: [
        {
            time: 60,
            text: 'One more chance',
        },
        {
            time: 120,
            text: '谁でもいいはずなのに',
        },
        {
            time: 180,
            text: '夏の想い出がまわる',
        },
        {
            time: 240,
            text: 'こんなとこにあるはずもないのに',
        },
        {
            time: 300,
            text: '终わり',
        },
    ],
});