import { Component, OnInit } from '@angular/core';
import { Rental } from 'src/app/models/Rental';
import { RentalService } from 'src/app/services/rental.service';

@Component({
  selector: 'app-rental',
  templateUrl: './rental.component.html',
  styleUrls: ['./rental.component.css'],
})
export class RentalComponent implements OnInit {
  constructor(private rentalService: RentalService) {}

  rentals: Rental[];
  ngOnInit(): void {}

  getCars() {
    this.rentalService.getRentals().subscribe((response) => {
      this.rentals = response.data;
    });
  }
}
