//paleta #6C568C #453073 #C8C1D9 #F2D6BD #F2ECE9
var bt = document.querySelector('#check');
var div = document.querySelector('.menu');
var div1 = document.querySelector('.men');
var div2 = document.querySelector('.men2');

bt.addEventListener('click', function() {
	if(div1.style.display === 'flex'){
		div1.style.display = 'none';
		div.style.backgroundColor = '#453073';
		div.style.width = '3vw';
		div.style.height = '5vh';
		div.style.marginTop = '2vh';
		div.style.marginLeft = '0vw';
		div.style.marginRight = '30vw';
		div2.style.display = 'none';	
	}else{
		div.style.backgroundColor = 'rgb(124, 106, 163)';
		div.style.width = '4vw';
		div.style.height = '6vh';
		div.style.marginTop = '1.5vh';
		div.style.marginLeft = '-0.5vw';
		div.style.marginRight = '29.5vw';
		div1.style.display = 'flex';
		div2.style.display = 'flex';
	}
});
