import { Component } from '@angular/core';
import { SongListComponent } from './songlist.component';
import { HTTP_PROVIDERS } from '@angular/http';
import { SongListService } from './services/songlist.service';

@Component({
  selector: 'my-app',
  template: `<h1>TrackPack</h1><songlist></songlist>`,
  directives: [SongListComponent],
  providers: [HTTP_PROVIDERS, SongListService]
})

export class AppComponent { }
