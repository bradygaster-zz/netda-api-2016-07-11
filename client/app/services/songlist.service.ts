import { Instrument } from '../models/instrument';
import { Song } from '../models/song';
import { Injectable } from '@angular/core';
import { Http } from '@angular/http';
import 'rxjs/add/operator/map';

@Injectable()
export class SongListService {
    
    constructor(private http: Http){
    }

    getSongs() {
        return this.http.get('http://trackpack.azurewebsites.net/api/song')
                        .map(response => <Song[]>response.json());
    }
}