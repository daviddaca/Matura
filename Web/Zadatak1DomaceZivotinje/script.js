var cowSound = new Audio('audio/cow.mp3');
var sheepSound = new Audio('audio/sheep.mp3');

function cow() {
    cowSound.play();
}

function sheep() {
    sheepSound.play();
}

function info(url) {
    window.open(url, 'targetWindow', 'toolbar=no, location=no, status=no, menubar=no, scrollbars=yes, resizable=yes, width=320, height=500');
}
