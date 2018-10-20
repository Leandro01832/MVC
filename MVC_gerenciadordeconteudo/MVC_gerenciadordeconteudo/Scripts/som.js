inicio();

var links = document.getElementsByTagName("a");

for (var i = 0; i <= links.item.length; i++) {
    alert("entrou na função");
    links[i].addEventListener("click", play_evento, false)
}

window.onload = function () {
   
}



function inicio() {
    var corrente = 0;
    var audio = $("#audio");
    var playlist = $(".playlist");
    var tracks = playlist.find("li a");
    var len = tracks.length - 1;
    audio[0].play();
    playlist.find("a").click(function (e) {
        e.preventDefault();
        link = $(this);
        corrente = link.parent().index();
        run(link, audio[0]);
    });
    audi0[0].addEventListener("ended", function () {
        corrente++;
        if(corrente == len){
            corrente = 0;
            link = playlist.find("a")[0];
        } else {
            link = playlist.find("a")[corrente];
        }
        run($(link), audio[0]);
    });
}


function run(link, player) {
    player.src = link.attr("href");
    par = link.parent();
    par.addClass("active").siblings().removeClass("active");
    player.load();
    player.play();
}










   
