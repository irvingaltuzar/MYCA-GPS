
var timeOut;


class Item {
    constructor(icon, backgroundColor) {
        this.$element = $(document.createElement("div"));
        this.icon = icon;
        this.$element.addClass("item");
        this.$element.css("background-color", backgroundColor);
        var i = document.createElement("i");
        $(i).addClass("mdi mdi-" + icon);
        this.$element.append(i);
        this.prev = null;
        this.next = null;
        this.isMoving = false;
        var element = this;
        this.$element.on("mousemove", function () {
            clearTimeout(timeOut);
            timeOut = setTimeout(function () {
                if (element.next && element.isMoving) {
                    element.next.moveTo(element);
                }
            }, 10);
        });
    }

    moveTo(item) {
        anime({
            targets: this.$element[0],
            left: item.$element.css("left"),
            top: item.$element.css("top"),
            duration: 700,
            elasticity: 500
        });
        if (this.next) {
            this.next.moveTo(item);
        }
    }

    updatePosition() {
        anime({
            targets: this.$element[0],
            left: this.prev.$element.css("left"),
            top: this.prev.$element.css("top"),
            duration: 80
        });

        if (this.next) {
            this.next.updatePosition();
        }
    }
}

class Menu {
    constructor(menu) {
        this.$element = $(menu);
        this.size = 0;
        this.first = null;
        this.last = null;
        this.timeOut = null;
        this.hasMoved = false;
        this.status = "closed";
    }

    add(item) {
        var menu = this;
        if (this.first == null) {
            this.first = item;
            this.last = item;
            this.first.$element.on("mouseup", function () {
                if (menu.first.isMoving) {
                    menu.first.isMoving = false;
                } else {
                    menu.click();
                }
            });
            item.$element.draggable(
                {
                    start: function () {
                        menu.close();
                        item.isMoving = true;
                    }
                },
                {
                    drag: function () {
                        if (item.next) {
                            item.next.updatePosition();
                        }
                    }
                },
                {
                    stop: function () {
                        item.isMoving = false;
                        item.next.moveTo(item);
                    }
                }
            );
        } else {
            this.last.next = item;
            item.prev = this.last;
            this.last = item;
        }
        this.$element.after(item.$element);


    }

    open() {
        this.status = "open";
        var current = this.first.next;
        var iterator = 1;
        var head = this.first;
        var sens = head.$element.css("left") < head.$element.css("right") ? 1 : -1;
        while (current != null) {
            anime({
                targets: current.$element[0],
                left: parseInt(head.$element.css("left"), 10) + (sens * (iterator * 50)),
                top: head.$element.css("top"),
                duration: 500
            });
            iterator++;
            current = current.next;
        }
    }

    close() {
        this.status = "closed";
        var current = this.first.next;
        var head = this.first;
        var iterator = 1;
        while (current != null) {
            anime({
                targets: current.$element[0],
                left: head.$element.css("left"),
                top: head.$element.css("top"),
                duration: 500
            });
            iterator++;
            current = current.next;
        }
    }

    click() {
        if (this.status == "closed") {
            this.open();
        } else {
            this.close();
        }
    }

}

var menu = new Menu("#myMenu");
var item1 = new Item("menu");
var item2 = new Item("highway", "#FF5C5C");
var item3 = new Item("car", "#5CD1FF");
var item4 = new Item("file-account", "#FFF15C");
var item5 = new Item("link", "#64F592");

//Inicialiacion menu draggable
menu.add(item1);
menu.add(item2);
menu.add(item3);
menu.add(item4);
menu.add(item5);

$(document).delay(50).queue(function (next) {
    menu.open();
    next();
    $(document).delay(1000).queue(function (next) {
        menu.close();
        next();
    });
});



//********************FUNCTIONS********************************



function InitMap() {

    document.getElementById('mapid').innerHTML = "<div id='map' style='width: 100%; height: 100%;'></div>";
    var markersArray = [];
    var truckArray = [];
    var trafficLayer = new google.maps.TrafficLayer();
    var infowindow = new google.maps.InfoWindow();
    var styledMapType = new google.maps.StyledMapType(
        [
            {
                "elementType": "geometry",
                "stylers": [
                    {
                        "color": "#242f3e"
                    }
                ]
            },
            {
                "elementType": "labels.text.fill",
                "stylers": [
                    {
                        "color": "#746855"
                    }
                ]
            },
            {
                "elementType": "labels.text.stroke",
                "stylers": [
                    {
                        "color": "#242f3e"
                    }
                ]
            },
            {
                "featureType": "administrative.locality",
                "elementType": "labels.text.fill",
                "stylers": [
                    {
                        "color": "#d59563"
                    }
                ]
            },
            {
                "featureType": "poi",
                "elementType": "labels.text.fill",
                "stylers": [
                    {
                        "color": "#d59563"
                    }
                ]
            },
            {
                "featureType": "poi.park",
                "elementType": "geometry",
                "stylers": [
                    {
                        "color": "#263c3f"
                    }
                ]
            },
            {
                "featureType": "poi.park",
                "elementType": "labels.text.fill",
                "stylers": [
                    {
                        "color": "#6b9a76"
                    }
                ]
            },
            {
                "featureType": "road",
                "elementType": "geometry",
                "stylers": [
                    {
                        "color": "#38414e"
                    }
                ]
            },
            {
                "featureType": "road",
                "elementType": "geometry.stroke",
                "stylers": [
                    {
                        "color": "#212a37"
                    }
                ]
            },
            {
                "featureType": "road",
                "elementType": "labels.text.fill",
                "stylers": [
                    {
                        "color": "#9ca5b3"
                    }
                ]
            },
            {
                "featureType": "road.highway",
                "elementType": "geometry",
                "stylers": [
                    {
                        "color": "#746855"
                    }
                ]
            },
            {
                "featureType": "road.highway",
                "elementType": "geometry.stroke",
                "stylers": [
                    {
                        "color": "#1f2835"
                    }
                ]
            },
            {
                "featureType": "road.highway",
                "elementType": "labels.text.fill",
                "stylers": [
                    {
                        "color": "#f3d19c"
                    }
                ]
            },
            {
                "featureType": "transit",
                "elementType": "geometry",
                "stylers": [
                    {
                        "color": "#2f3948"
                    }
                ]
            },
            {
                "featureType": "transit.station",
                "elementType": "labels.text.fill",
                "stylers": [
                    {
                        "color": "#d59563"
                    }
                ]
            },
            {
                "featureType": "water",
                "elementType": "geometry",
                "stylers": [
                    {
                        "color": "#17263c"
                    }
                ]
            },
            {
                "featureType": "water",
                "elementType": "labels.text.fill",
                "stylers": [
                    {
                        "color": "#515c6d"
                    }
                ]
            },
            {
                "featureType": "water",
                "elementType": "labels.text.stroke",
                "stylers": [
                    {
                        "color": "#17263c"
                    }
                ]
            }
        ],
        { name: 'Night' });

    

    var map = new google.maps.Map(document.getElementById('map'), {
        zoom: 5.5,
        center: new google.maps.LatLng(23.1040494, -108.8204545),
        mapTypeId: 'styled_map',
        mapTypeControlOptions: {
            mapTypeIds: ['roadmap', 'satellite', 'hybrid', 'terrain',
                'styled_map']
        }

    });

    map.mapTypes.set('styled_map', styledMapType);

    $(".mdi-highway").on("click", function () {

        if (trafficLayer.getMap() == null) {
            //traffic layer is disabled.. enable it
            trafficLayer.setMap(map);
        } else {
            //traffic layer is enabled.. disable it
            trafficLayer.setMap(null);
        }
    })
   
    //map.setTilt(45);
    //map.setMapTypeId('styled_map');

    
    function updatePositions() {
        try {

            $(function () {
                if (markersArray) {
                    for (i in markersArray) {
                        markersArray[i].setMap(null);
                    }
                    markersArray.length = 0;

                }
            });
            $("#sidebarnav").html("");
            //deleteOverlays()
        } catch (error) {
            alert(error);
        }

        $.ajax({
            type: "POST",
            url: "/Usuarios/positions",
            data: '{}',
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (data) {
                truckArray = $.parseJSON(data);
                console.log(truckArray);
                $.each($.parseJSON(data), function (i, item) {
                    if (item["PosVelocidad"] == 0 & item["PosIgnicion"] == 0) {
                        marker = new google.maps.Marker({
                            position: new google.maps.LatLng(item["PosLatitud"], item["PosLogitud"]),
                            map: map,
                            icon: "/images/trucks/truck_red.png"
                        });

                    } else {
                        marker = new google.maps.Marker({
                            position: new google.maps.LatLng(item["PosLatitud"], item["PosLogitud"]),
                            map: map,
                            icon: "/images/trucks/truck_green.png",


                        });
                    }
                    markersArray.push(marker);
                  
                    //events Marcadores
                    google.maps.event.addListener(marker, 'click', (function (marker) {
                        return function () {
                            //Informacion de unidad en event click marker
                            $(".nav-item").removeClass("active");

                            $(".nav-item span").css("color", "white")
                            $("#" + item["DeviceEco"] + " span").css("color", "black")

                            $("#" + item["DeviceEco"] + "").addClass('active');

                            infowindow.setContent('<strong style="font-size:15px;text-align:center">' + item["DeviceEco"] + '</strong><br><p>Direccion: ' + item["PosLatitud"] + '</p><p>Longitud: ' + item["PosLogitud"] + '</p><p>Velocidad: ' + item["PosVelocidad"] + ' km</p>');
                            infowindow.open(map, marker);


                            InfoPanel();
                            collapsible_panel()



                        }
                    })(marker, i));

                    google.maps.event.addListener(marker, 'dblclick', (function (marker, i) {
                        return function () {
                            map.setCenter(marker.getPosition());
                            map.setZoom(15);

                        }
                    })(marker, i));


                    //Function Elementos panel de informacion
                    function InfoPanel() {
                        //PANEL Posicion
                        $("#lblPosicionPanel").text(item["PosLatitud"] + "," + item["PosLogitud"]);
                        $("#lblUConexionPanel").text(item["PosFechahora"]);


                        //PANEL Cluster
                        $("#lblVelocidadPanel").text(item["PosVelocidad"] + "km");

                        if (item["PosIgnicion"] == 0) {
                            $("#lblignition").text("Apagada");
                        } else {
                            $("#lblignition").text("Encendida");
                        }

                        $("#lblOdoPanel").text(item["PosOdometro"] + "km");

                        if (item["PosCombistiblenivel"] == -1) {
                            $("#lblCombustible").text("No Disponible")
                        } else {
                            $("#lblCombustible").text(item["PosCombistiblenivel"] + " lt");
                        }

                        //PANEL LOCALIZADOR
                        $("#lblProvPanel").text(item["DeviceProveedor"]);
                        $("#lblDevicePanel").text(item["DeviceId"]);
                        $("#lblTruckPanel").text(item["DeviceClass"]);

                        //Top Panel Information
                        $("#nombreUnidadGps").text(item["DeviceEco"]);
                        $("#lblUbicacionActualdirCompletaPanel").text(item["PosDireccion"]);



                    }



                    //Apartado de informacion de Unidades 
                    if (item["PosVelocidad"] == 0 & item["PosIgnicion"] == 0) {

                        $("#sidebarnav").append("<div class='nav-item' id='" + item["DeviceEco"] + "'><div style='background: rgba(113, 155, 89, 1);border-bottom: 0px;width:15%;display:block'><div ><img src='images/InfoPanel/time.svg' style='width:30px;margin-top:5px'></div></div ><div style='width:70%;display:block'> <span style='font-size:15px;position:relative;left:15px;top:10px;color:white'>" + item["DeviceEco"] + "</span></div><div style='width:10%;display:block'><img src='images/trucks/truck_red.png' style='width:40px'></div></div > ");
                    }
                    else {
                        $("#sidebarnav").append("<div class='nav-item' id='" + truckArray[i].DeviceEco + "'><div style='background: rgba(113, 155, 89, 1);border-bottom: 0px;width:15%;display:block'><div ><img src='images/InfoPanel/time.svg' style='width:30px;margin-top:5px'></div></div ><div style='width:70%;display:block'> <span style='font-size:15px;position:relative;left:15px;top:10px;color:white'>" + truckArray[i].DeviceEco + "</span></div><div style='width:10%;display:block'><img src='images/trucks/truck_green.png' style='width:40px'></div></div > ");

                    }

                    $("#" + item["DeviceEco"] + "").bind("click", (function (marker, i) {
                        return function () {
                            $(".nav-item span").css("color", "white")
                            $(".nav-item").removeClass("active");
                            //$(".nav-item span").css("color", "white")
                            $("#" + truckArray[i].DeviceEco + " span").css("color", "black")

                            $(this).addClass('active');
                            infowindow.setContent('<strong style="font-size:15px;text-align:center">' + item["DeviceEco"] + '</strong><br><p>Direccion: ' + item["PosLatitud"] + '</p><p>Longitud: ' + item["PosLogitud"] + '</p><p>Velocidad: ' + item["PosVelocidad"] + ' km</p>');
                            infowindow.open(map, marker);
                            map.setZoom(6);

                            InfoPanel();
                            collapsible_panel()

                        }
                    })(marker, i));

                    $("#" + item["DeviceEco"] + "").bind("dblclick", (function (marker) {
                        return function () {
                            map.setCenter(marker.getPosition());
                            map.setZoom(15);

                            InfoPanel();
                        }
                    })(marker, i));

                });
                
              
            },
            failure: function (response) {
                alert(response.responseText);
            },
            error: function (response) {
                alert(response.responseText);
            }

        });
       

    }
            

    function collapsible_panel(){
        var hideWidth = '-625px'; //width that will be hidden
        var collapsibleEl = $('.collapsible'); //collapsible element
        var buttonEl = $("#btnCerrarPanelGPSeIndicadores"); //button inside element

        collapsibleEl.css({ 'margin-left': hideWidth }); //on page load we'll move and hide part of elements
        var curwidth = buttonEl.parent().offset();
        if (curwidth.left > 0) //compare margin-left value
        {
            buttonEl.css({ 'height': '40px' });

            //animate margin-left value to -490px
            buttonEl.parent().animate({ marginLeft: hideWidth }, 300);
            buttonEl.html('&raquo;'); //change text of button
        } else {

            //animate margin-left value 0px
            buttonEl.css({
                'height': '140px',
                'background-color': ' #2f2d2d;',
                'color': 'white'
            });


            collapsibleEl.css({ 'height': '140px' });
            buttonEl.parent().animate({ marginLeft: "0" }, 300);
            buttonEl.html('<span style="font-size: 20px; color: white; font-family: Trebuchet MS; margin-top: 15px; margin-left: 4px;">&laquo;</span>'); //change text of button
        }

    }
    

    updatePositions();


    setInterval(updatePositions, 30000);

   
};



function infodiv() {
    var hideWidth = '-625px'; //width that will be hidden
    var collapsibleEl = $('.collapsible'); //collapsible element
    var buttonEl = $("#btnCerrarPanelGPSeIndicadores"); //button inside element

    collapsibleEl.css({ 'margin-left': hideWidth }); //on page load we'll move and hide part of elements
    $(buttonEl).click(function () {
        var curwidth = $(this).parent().offset(); //get offset value of the element
        if (curwidth.left > 0) //compare margin-left value
        {
            buttonEl.css({
                'height': '40px',
                'background-color': '#2f2d2d;',
                'color': 'white',
                'font-size': '14px'
            });

            collapsibleEl.css({ 'height': '40px' });
            //animate margin-left value to -490px
            $(this).parent().animate({ marginLeft: hideWidth }, 300);
            $(this).html('&raquo;'); //change text of button
        } else {
            //animate margin-left value 0px
            buttonEl.css({
                'height': '140px',
                'background-color': ' #2f2d2d;',
                'color': 'white'
            });


            collapsibleEl.css({ 'height': '140px' });
            $(this).parent().animate({ marginLeft: "0" }, 500);
            $(this).html(' <span style="font-size: 20px; color: white; font-family: Trebuchet MS; margin-top: 15px; margin-left: 4px;">&laquo;</span>'); //change text of button
        }
    });
}

$(document).ready(function () {

    InitMap();
    infodiv();

    $(function () {

        $('#timer').pietimer({
            timerSeconds: 30,
            color: 'white',
            fill: false,
            showPercentage: true,
            callback: function () {

                $('#timer').pietimer('start');

            }

        });


    });


    $("#input-buscar").on("keyup", function (e) {

        $(this).val($(this).val().toUpperCase());
            var search = $("#input-buscar").val();

        

                $(".nav-item span").find(function (i, elem) {

                    if ($("#input-buscar").val() == "") {
                    
                        $(".nav-item").show();

                    } else {
                        if ($(".nav-item span:contains('" + search + "'_)")) {
                            console.log($(this).text());
                            $(".nav-item").hide();
                            $(".nav-item:contains('" + search + "')").show();

                        } else {
                            console.log(search)
                        }
                    }
                    });

        });
    $("#input-buscar").on("search", function () {
        if ($("#input-buscar").val()=="") {

            $(".nav-item").show();

        } 
    });

    
});
document.getElementById("mapid").innerHTML="<div id='map' style='width: 100%; height: 100%;'></div>"






    //var elem = $("#sidebarnav .nav-item")

            //var dataObject = JSON.stringify({
            //    'DeviceEco': $("#input-buscar").val()
            //});
            //$.ajax({
            //    type: "POST",
            //    url: "/Usuarios/Buscar_Unidad",
            //    data: dataObject,
            //    dataType: "json",
            //    contentType: "application/json; charset=utf-8",
            //    success: function (data) {
            //        $("#sidebarnav").html("");
            //        $.each($.parseJSON(data), function (i, item) {
            //if (e.which == 13) {

        //}


            //Apartado de informacion de Unidades 
            //if (item["PosVelocidad"] == 0 & item["PosIgnicion"] == 0) {

            //    $("#sidebarnav").append("<div class='nav-item' id='" + item["DeviceEco"] + "'><div style='background: rgba(113, 155, 89, 1);border-bottom: 0px;width:15%;display:block'><div ><img src='images/InfoPanel/time.svg' style='width:30px;margin-top:5px'></div></div ><div style='width:70%;display:block'> <span style='font-size:15px;position:relative;left:15px;top:10px;color:white'>" + item["DeviceEco"] + "</span></div><div style='width:10%;display:block'><img src='images/trucks/truck_red.png' style='width:40px'></div></div > ");
            //}
            //else {
            //    $("#sidebarnav").append("<div class='nav-item' id='" + item["DeviceEco"] + "'><div style='background: rgba(113, 155, 89, 1);border-bottom: 0px;width:15%;display:block'><div ><img src='images/InfoPanel/time.svg' style='width:30px;margin-top:5px'></div></div ><div style='width:70%;display:block'> <span style='font-size:15px;position:relative;left:15px;top:10px;color:white'>" + item["DeviceEco"] + "</span></div><div style='width:10%;display:block'><img src='images/trucks/truck_green.png' style='width:40px'></div></div > ");

            //}

            //        })

            //        },
            //});


//$(function() {
//    var mymap = L.map('mapid').setView([18.8321447, 97.105492], 13);
//});
//    //var osmUrl = 'http://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png',
//    //    osmAttribution = 'Map data © <a href="http://openstreetmap.org">OpenStreetMap</a> contributors,' +
//    //        ' <a href="http://creativecommons.org/licenses/by-sa/2.0/">CC-BY-SA</a>',
//    //    osmLayer = new L.TileLayer(osmUrl, { maxZoom: 18, attribution: osmAttribution });
//    //var map = new L.Map('map');
//    //map.setView(new L.LatLng(18.8321447, -97.105492), 16);
//    //map.addLayer(osmLayer);
//    //map.zoomControl.setPosition("topright");


//    //var marker = L.marker([18.8321447, -97.105492])
//    //        .addTo(map)
//    //        .bindPopup("<p><b>Unidad:<b>TR250 ")


//  // 3rd argument will be passed to 'this' object, when click event occures
//       //var validatorsLayer = new OsmJs.Weather.LeafletLayer({ lang: 'en' });
//    //map.addLayer(validatorsLayer);
    //mapboxgl.accessToken = 'pk.eyJ1IjoiaXJ2aW5nYWx0dXphciIsImEiOiJjazh0Mzc1YWswMWRiM21vNWt5c2F5eHMyIn0.4ttoUPByjdRzjWv6LZCcRw';
    //var map = new mapboxgl.Map({
    //    container: 'map', // container id
    //    style: 'mapbox://styles/mapbox/streets-v11', // stylesheet location
    //    center: [-97.105492, 18.8321447], // starting position [lng, lat]
    //    zoom: 16 // starting zoom
    //});
    //map.addControl(new mapboxgl.NavigationControl());

    //var map = new GMaps({
    //    div: '#map',
    //    lat: 23.1040494,
    //    lng: -108.8204545,
    //    zoom: 5.5
    //});

  //var panorama = new google.maps.StreetViewPanorama(
                        //    document.getElementById('idDivStreeViewPanelInfoPanorama'), {
                        //    position: marker.getPosition(),
                        //    pov: {
                        //        heading: 34,
                        //        pitch: 10
                        //    }
                        //});
                        //if (marker.getAnimation() !== null) {
                        //    marker.setAnimation(null);
                        //} else {
                        //    marker.setAnimation(google.maps.Animation.BOUNCE);
                        //}
                        //map.setStreetView(panorama);