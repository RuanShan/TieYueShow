$(document).ready(function(){

  var player = videojs(document.querySelector('.video-js'));
  
  $('#myModal').on('hidden.bs.modal', function (e) {
    player.pause();
  })
  $('#myModal').on('show.bs.modal', function (e) {
    player.play();
  })

  $('.play-audio-btn').click(function(){
	  var $this = $(this);
	  var audioElement = document.getElementById('audio-js');
	$this.toggleClass('audio-off audio-on');
	  if($this.hasClass('audio-on'))
	  {
	    audioElement.play();
	  }else{
		audioElement.pause();  
	  }
  })
});
