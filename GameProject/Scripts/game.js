var player = {};
var game = {};

game.baseInterval = 1000;

player.name = "Me";
//currency
player.wood = 0;
player.autoAddInterval = 0;

//first upgrade
player.autoWoodRate = 0;
player.hutBaseCost = 10;


$(document).ready(function () {
    $('#playerName').text = player.name;

    $('#collectWood').click(function () {
        player.wood++;
        $('woodCount').text(player.wood);
    });
    $('#buyAutoWood').click(function () {
        player.autoWoodRate++;
        player.autoAddInterval += .2;
        player.wood -= player.hutBaseCost;
        player.hutBaseCost *= 1.05;
    });

    window.setInterval(function () {
        update{ };
    },game.baseInterval);
});

function update() {
    player.wood += player.autoAddInterval;
    $('woodCount').text(player.wood);
}