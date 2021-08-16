import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";

@Injectable()
export class EventService {

    getEventById(id: number): Observable<Event> {
        return this.http.get<Event>("/api/Event/" + id);
    }

    constructor(private http: HttpClient) {}
}