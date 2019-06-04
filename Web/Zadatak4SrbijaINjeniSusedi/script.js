var zastave = document.getElementsByClassName('zastava');

var himne = [];
loadHimne();

for(var i = 0; i < zastave.length; i++){
    zastave[i].onmouseover = (
        function(n){
            return function() {
                playHimna(n);
            }
        }
    )(i);

    zastave[i].onmouseout = (
        function(n){
            return function() {
                stopHimna(n);
            }
        }
    )(i);
}

function loadHimne() {
    for(var i = 0; i < zastave.length; i++) {
        // ovo je jer niste stavili dovoljno mesta za upload :L
        var h = new Audio('sounds/' + zastave[i].id + '.ogg');
        himne.push(h);
    }
}

function playHimna(h) {
    himne[h].play();
}

function stopHimna(h) {
    himne[h].pause();
    himne[h].currentTime = 0;
}

function Open(url) {
    window.open(url, 'targetWindow', 'toolbar=no, location=no, status=no, menubar=no, scrollbars=yes, resizable=yes, width=320, height=500');
}
