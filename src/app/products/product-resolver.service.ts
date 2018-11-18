import { ProductService } from './product.service';
import { Injectable } from '@angular/core';
import { Resolve, ActivatedRouteSnapshot, RouterStateSnapshot, Router } from '@angular/router';
import { IProduct } from './product';
import { Observable } from 'rxjs/Observable';

@Injectable({ // services get injectable
  providedIn: 'root'
})
export class ProductResolverService implements Resolve<IProduct> {

  resolve(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): Observable<IProduct> {
    const id = route.params['id'];
    if (isNaN(id)) {
      console.log('Product id eas not a number: ${id}');
      this.router.navigate(['/products']);
      return Observable.of(null);
    }
    return this.producService.getProduct(+id)
      .map(product => {
        if (product) {
          return product;
        }
        console.log('Product was not found: ${id}');
        this.router.navigate(['/products']);
        return null; // map converts it ot Observable 
      })
      .catch(error => {
        console.log('Retrieval error ${error}');
        this.router.navigate(['/products']);
        return Observable.of(null);
      });
  }

constructor(private producService: ProductService,
   private router: Router) { }

}
