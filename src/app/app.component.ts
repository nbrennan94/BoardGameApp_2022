import { Component } from '@angular/core';
import { RepositoryService } from './repository.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'BoardGameWebApp_2022';

  constructor(private repositoryService: RepositoryService){}

  boardGames: any;

  ngOnInit():void {
    this.getGames();
  }

  getGames() {
    this.repositoryService.getboardGames().subscribe(
      (response) => { this.boardGames = response;});
  }
}
