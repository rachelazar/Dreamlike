import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { Event } from "../models/event.model";

@Injectable()
export class EventService {

    getEvents(): Observable<Event[]> {
        return this.http.get<Event[]>("/api/Event");
    }

    getEventById(id: number): Observable<Event> {
        return this.http.get<Event>("/api/Event/" + id);
    }

    constructor(private http: HttpClient) {}
}