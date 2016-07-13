import { Component } from '@angular/core';
import { Song } from './models/song';
import { SongListService } from './services/songlist.service'

@Component({
  selector: 'songlist',
  templateUrl: '/views/songlist.html'
})

export class SongListComponent { 
  songs: Song[];

  constructor(private songListService : SongListService) {
  }

  ngOnInit() {
    this.songListService.getSongs()
      .subscribe(songsFromApi => this.songs = songsFromApi);
  }
}