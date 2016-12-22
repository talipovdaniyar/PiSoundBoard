using PiSoundBoard.Api.DTOs;
using Restup.Webserver.Attributes;
using Restup.Webserver.Models.Schemas;
using System;
using System.Threading.Tasks;
using Windows.Media.Core;
using Windows.Media.Playback;
using Windows.Storage;

namespace PiSoundBoard.Api.Controllers
{
    [RestController(InstanceCreationType.Singleton)]
    public class SoundboardController
    {
        private MediaPlayer _mediaPlayer;

        [UriFormat("/buildfailed/")]
        public async Task<PostResponse> playBuildFailedSound([FromContent]BuildData buildData)
        {
            try
            {
                var storageFile = await KnownFolders.CameraRoll.GetFileAsync("ShameShameShame.mp3");
                _mediaPlayer = BackgroundMediaPlayer.Current;
                _mediaPlayer.AutoPlay = false;
                _mediaPlayer.Source = MediaSource.CreateFromStorageFile(storageFile);
                _mediaPlayer.Play();

                return new PostResponse(PostResponse.ResponseStatus.Created,"t");
            }
            catch 
            {
                return new PostResponse(PostResponse.ResponseStatus.Conflict,"tes");
            }
        }
    }
}
