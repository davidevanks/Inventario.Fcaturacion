/*Visualizar imagen*/

$("#imagen").change(function () {
    let imagen = this.files[0];

    if (imagen["type"] != "image/jpeg" && imagen["type"] != "image/png") {
        $("#imagen").val("");
        $(".previsualizar").attr("src", "../Content/img/img_logo/TuLogo.png");
        alert('Formato de imagen invalido');
    } else if (imagen["size"] > 2000000) {
        $("#imagen").val("");
        $(".previsualizar").attr("src", "../Content/img/img_logo/TuLogo.png");
        alert('El peso máximo de la imagen es de 200mb');
    } else
    {
        let datosImagen = new FileReader;
        datosImagen.readAsDataURL(imagen);

        $(datosImagen).on("load", function (event) {
            let rutaImagen = event.target.result;
            $(".previsualizar").attr("src", rutaImagen);
        });
    }
});