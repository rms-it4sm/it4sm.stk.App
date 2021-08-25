import { Component, OnInit } from '@angular/core';
import { AppInfoService } from 'src/app/services/app-info.service';
import { EventBusService } from 'src/app/services/event-bus.service';

@Component({
  selector: 'app-current-user',
  templateUrl: './current-user.component.html',
  styleUrls: ['./current-user.component.scss'],
})
export class CurrentUserComponent implements OnInit {

  constructor(private appInfoService: AppInfoService,
    private eventBus: EventBusService) {

   }

  image: string;
    name: string;

    ngOnInit() {
        this.loadDataAsync();

        this.eventBus.subscribe('authorized', () => {
          this.loadDataAsync();
        });
    }

    async loadDataAsync() {
        const user = await this.appInfoService.getCurrentUserAsync();

        if (!user) {
          return;
        }

        this.image = user ? user.image : null;
        this.name = user.name;
    }
}
