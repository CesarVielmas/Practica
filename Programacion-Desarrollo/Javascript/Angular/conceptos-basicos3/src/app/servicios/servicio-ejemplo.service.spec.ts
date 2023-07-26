import { TestBed } from '@angular/core/testing';

import { ServicioEjemploService } from './servicio-ejemplo.service';
//Parte de las pruebas para los servicios
describe('ServicioEjemploService', () => {
  let service: ServicioEjemploService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ServicioEjemploService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
