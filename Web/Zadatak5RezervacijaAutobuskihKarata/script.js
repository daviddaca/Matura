var sedista = document.getElementsByClassName('sediste');

LoadSedista(13);
SetBusy(7);


for(var i = 0; i < sedista.length; i++) {
    sedista[i].onclick = function(){
        var z = document.getElementsByName('brSedista')[0];
        if(this.className.indexOf('zauzeto') == -1) {
            var rez = document.getElementsByName('brSedista')[0].value.split(',');
            for(var j = 0; j < rez.length; j++) {
                if(rez[j] == this.innerHTML.trim()) {
                    return;
                }
            }

            z.value += this.innerHTML.trim() + ',';
        } else {
            alert("То седиште је заузето!");
        }
    }
}

function SetBusy(num){
	for (i=0;i<num;i++){
		var rnd = Math.floor(Math.random() * 52) + 2;
		 for(sed = 0; sed < sedista.length; sed++) {
			 if(sedista[sed].innerHTML.trim() == rnd) {
				 sedista[sed].className += " zauzeto";
			 }
		 }
	}
}

function LoadSedista(rows){
	var rez = document.getElementById("autobus");
	var sediste = 2
	var html = "";
	
	for(row=0;row<rows;row++){
		for(j=1;j<=4;j++){
			
			if (row == 0 && j==1){
				html += "<div class='sediste vozac zauzeto' style='background-color:gray;'>V</div>";	
				j++;				
			}
			
			html += "<div class='sediste'>" + sediste + "</div>";													
			if (j==2){
				html += "<div class='hodnik'></div>";
			}
			sediste ++;
			
		}
	}
	rez.innerHTML = html + rez.innerHTML;
}

function Posalji() {
    var rez = document.getElementsByName('brSedista')[0].value.split(',');
    for(var i = 0; i < sedista.length; i++) {
        for(var j = 0; j < rez.length; j++) {
            if(sedista[i].innerHTML.trim() == rez[j]) {
                sedista[i].className += " zauzeto";
                break;
            }
        }
    }

    var email = document.getElementsByName('email')[0].value;
    var ime = document.getElementsByName('ime')[0].value;
    var body = document.getElementsByName('brSedista')[0].value;

    window.location.href = 'mailto:rezervacija@autobuska.rs?cc=' + email + '&subject=Rezervacija (' + ime + ')&body=' + body;

    document.getElementsByName('brSedista')[0].value = '';
    document.getElementsByName('ime')[0].value = '';
    document.getElementsByName('email')[0].value = '';
}
