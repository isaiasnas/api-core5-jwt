(function () {
    window.addEventListener("load", function () {
        setTimeout(function () {
            var logo = document.getElementsByClassName('link');
            logo[0].href = "http://webeasy.com.br";
            logo[0].target = "_blank";

            logo[0].children[0].alt = "Api - ISAIASNAS";
            logo[0].children[0].src = "http://webeasy.com.br/img/imgs/logos/2.png";

            var txt = document.getElementsByClassName('select-label');
            txt[0].children[0].innerText = "escolha a versão";
        });
    });
})();

