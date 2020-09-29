import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {

  title = 'Hello world interpolation';
  students: any;
  constructor(private http: HttpClient) {

  }
  ngOnInit() {
    this.getStudents();
  }

  getStudents() {
    this.http.get('http://localhost:5000/api/student').subscribe(response => {
      this.students = response;
    }, error => {
      console.log('ya big goon!' + error);
    });
  }
}
