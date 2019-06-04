var id = 1;
PostaviSliku(id);

function PostaviSliku(id) {
    var x = document.getElementById('activeImage');
    x.innerHTML = '<img src="images/slika' + id + '.jpg"/>';

    var z = document.getElementById('gHeaderContainer');
    z.innerHTML = 'slika' + id + '.jpg';
}
