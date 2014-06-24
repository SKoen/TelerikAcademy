/**
 * Created by Sh0rti on 6/16/2014.
 */
var imageNames = ['gig_img_2.jpg', 'images.jpg', 'keep-calm-and-code-javascript-3.png', 'Programming-Code-Javascript-Friendship.jpg'];
var move = 0;
$('<button>').text('Previous')
    .css({
        'width': '80px',
        'height': '40px'
    }).on('click', function(){move-=2; sliderMove()}).appendTo('body');

$('<button>').text('Next')
    .css({
        'width': '80px',
        'height': '40px'
    })
    .on('click', function(){move+=1; sliderMove()})
    .appendTo('body');

function sliderMove(){
    $('img').remove();
    $('<img>').attr({
        'src': './img/' + imageNames[move],
        'width': '500px',
        'height': '300px'
    }).appendTo('#wrapar');
    if(move >= 3 || move < 0){
        move = 0;
    }
    else{
        move++;
    }
    setTimeout(sliderMove, 5000);
}
sliderMove();