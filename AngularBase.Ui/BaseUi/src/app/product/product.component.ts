import { Component, OnInit } from '@angular/core';
import { ProductsService } from '../services/products.service';
import { Product } from '../models/objects';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css']
})

export class ProductComponent implements OnInit {

  product: Product = new Product();
  products: Product[] = [];
  errorMessage: string = "";

  constructor(private productsService : ProductsService) {  }

  ngOnInit() {
    //sample data pull
    this.productsService.getProduct(1)
      .subscribe((product: Product) => this.product = product);

     this.productsService.getProducts()
      .subscribe((products: Product[]) => this.products = products);
  }

  save(product: Product) {
    this.productsService.update(product)
      .subscribe((status: boolean) => {
          if (status) {
            this.product = product;
          } else {
              this.errorMessage = 'Unable to save product.';
          }
      });
  }
}
