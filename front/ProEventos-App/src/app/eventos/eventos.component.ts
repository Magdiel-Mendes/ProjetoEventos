import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.scss']
})
export class EventosComponent implements OnInit {

  public eventos: any;
  constructor(private http: HttpClient) { }

  ngOnInit(): void {
    this.getEventos();
  }
  public getEventos():void{
    this.http.get('https://localhost:3000/api/eventos').subscribe(
      res => this.eventos = res,
      err => console.log(err)
    );
  }
}
