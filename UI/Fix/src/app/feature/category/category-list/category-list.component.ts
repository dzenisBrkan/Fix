import { Component, OnInit } from '@angular/core';
import { Mehanics } from '../models/mehanics.model';
import { CategoryService } from '../services/category.service';

@Component({
  selector: 'app-category-list',
  templateUrl: './category-list.component.html',
  styleUrls: ['./category-list.component.css']
})
export class CategoryListComponent implements OnInit {
  
  mechanics: Mehanics[] = [];
  loading = true;

  constructor(private categoryService: CategoryService) {}

  ngOnInit(): void {
    this.categoryService.getMechanics().subscribe({
      next: (data) => {
        this.mechanics = data;
        this.loading = false;
      },
      error: (err) => {
        console.error('Error fetching mechanics:', err);
        this.loading = false;
      },
    });
  }

}
