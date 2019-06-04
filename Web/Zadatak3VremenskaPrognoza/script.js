function Prikazi() {
    var x = document.getElementById("grad");
    var z = x.value;

    var k = document.getElementById('prikaz');
    k.src = 'http://www.naslovi.net/vremenska-prognoza/' + z;
}
