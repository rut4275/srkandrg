import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import {classValunteer} from './volunteer/models/classValunteer'
import { Injectable } from '@angular/core';

@Injectable()
export class VolunteerService {
    constructor(private _http: HttpClient) {
    }

    getVolunteers(): Observable<classValunteer[]> {
        return this._http.get<classValunteer[]>("/api/Volunteer");
    }

    saveVolunteers(v: classValunteer): Observable<classValunteer[]> {
        return this._http.post<classValunteer[]>("/api/Volunteer",v);
    }
}