$(document).ready(function () {
    // Sayfa yüklendiğinde çalışacak JavaScript kodları buraya yazılabilir
    setMinStartDate();
});

function setMinStartDate() {
    // Bugünkü tarihi al
    var today = new Date();

    // Yarını hesapla
    var tomorrow = new Date(today);
    tomorrow.setDate(today.getDate() + 1);

    // Yarından sonraki tarihi formatla (gerekirse)
    var formattedTomorrow = formatDate(tomorrow);

    // Başlangıç tarih alanını seç ve en erken tarihi ayarla
    $("#StartDate").val(formattedTomorrow);
}

function formatDate(date) {
    // Tarihi "yyyy-MM-dd" formatına çevir
    var dd = String(date.getDate()).padStart(2, '0');
    var mm = String(date.getMonth() + 1).padStart(2, '0'); // Ocak 0, Şubat 1, vs.
    var yyyy = date.getFullYear();

    return yyyy + '-' + mm + '-' + dd;
}