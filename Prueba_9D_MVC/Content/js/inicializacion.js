/*$(document).ready(function(){
  $('.modal').modal();
});*/

$(document).ready(function(){
  $('.parallax').parallax();
});

$('.dropdown-trigger').dropdown();

$(document).ready(function(){
  $('.collapsible').collapsible();
});

$('.dropdown-trigger').dropdown();

$(document).ready(function(){
  $('.sidenav').sidenav();
});

$(document).ready(function(){
  $('.materialboxed').materialbox();
});

$(document).ready(function(){
  $('.collapsible').collapsible();
});


var hoy = new Date();
var dd = hoy.getDate();
var mm = hoy.getMonth();
var yyyy = hoy.getFullYear();
/*
$(document).ready(function(){
    $('.datepicker').datepicker(
        {
            maxDate: new Date(yyyy, mm, dd),
            minDate: new Date(1960, 1, 1),
            setDefaultDate: true,
            autoClose: true,
            defaultDate: new Date(yyyy, mm, dd),
            i18n:{
                months: ['Enero', 'Febrero', 'Marzo', 'Abril', 'Mayo', 'Junio', 'Julio', 'Agosto', 'Septiembre', 'Octubre', 'Novimebre', 'Diciembre'],
                monthsShort: ['Ene', 'Feb', 'Mar', 'Abr', 'May', 'Jun', 'Jul', 'Agost', 'Sep', 'Oct', 'Nov', 'Dic'],
                weekdays: ['Sunday', 'Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Saturday'],
                weekdaysShort: ['Dom', 'Lun', 'Mar', 'Mier', 'Jue', 'Vie', 'Sab'],
                weekdaysAbbrev: ['D', 'L', 'M', 'M', 'J', 'V', 'S']
            }
        }
    );
});
*/
$(document).ready(function(){
  $('.tooltipped').tooltip();
});

$(document).ready(function(){
  $('.modalmenu').modal({
    opacity: 0,
  });
});

