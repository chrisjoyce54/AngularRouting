import { ActivatedRoute } from '@angular/router';
import { Component, OnInit } from '@angular/core';

import { IProduct } from './product';
import { ProductService } from './product.service';

@Component({
    templateUrl: './product-list.component.html',
    styleUrls: ['./product-list.component.css']
})
export class ProductListComponent implements OnInit {
    pageTitle = 'Product List';
    imageWidth = 50;
    imageMargin = 2;
    showImage = false;
    listFilter: string;
    errorMessage: string;

    products: IProduct[];

    constructor(private productService: ProductService,
        private route: ActivatedRoute) { }

    toggleImage(): void {
        this.showImage = !this.showImage;
    }

    ngOnInit(): void {
        this.listFilter = this.route.snapshot.queryParams['filterBy'] || '';
        this.showImage = this.route.snapshot.queryParams['showImage'] === 'true';
        this.productService.getProducts()
                .subscribe(products => this.products = products,
                           error => this.errorMessage = <any>error);
    }
}
