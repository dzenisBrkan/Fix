import { CategoryService } from './../services/category.service';
import { Component, OnDestroy, OnInit } from '@angular/core';
import { AddCategoryRequest } from '../models/add-category-request.mode';
import { Subscription } from 'rxjs';

@Component({
  selector: 'app-add-category',
  templateUrl: './add-category.component.html',
  styleUrls: ['./add-category.component.css']
})
export class AddCategoryComponent implements OnDestroy {

 model: AddCategoryRequest;
 private addCategorySubscribtion?: Subscription

  constructor(private CategoryService: CategoryService) {
    this.model = {
      mechanic_name: '',
      mechanic_surname: '',
      mechanic_shop_name: '',
      mechanic_type: '',
      location: '',
      is_logged_in: false,
      rating: 1,
      review_count: 1,
      working_hours: '',
      services_offered: '',
      profile_created_at: new Date()
    }
   }

  ngOnInit() {
  }

  onFormSubmit(){
    this.addCategorySubscribtion = this.CategoryService.addCategory(this.model)
    .subscribe({
      next: (response) => {
        console.log('Successfull');
      },
      error: (err) => {
        console.error("Error occureed:", err);
      }
    })
  }

  ngOnDestroy(): void {
    this.addCategorySubscribtion?.unsubscribe();
  }
}
