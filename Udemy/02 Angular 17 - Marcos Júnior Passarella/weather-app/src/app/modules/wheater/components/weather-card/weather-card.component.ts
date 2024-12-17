import { Component, Input, OnInit } from '@angular/core';
import { faDroplet, faTemperatureHigh, faTemperatureLow, faWind } from '@fortawesome/free-solid-svg-icons';
import { WeatherDatas } from 'src/app/models/interfaces/WeatheDatas';

@Component({
  selector: 'app-weather-card',
  templateUrl: './weather-card.component.html',
  styleUrls: []
})
export class WeatherCardComponent {
//Dados da previsão do tempo recebidos pelo componente pai
@Input() weatherDatasInput!: WeatherDatas;

minTemperatureIcon = faTemperatureLow;
maxTemperaturaIcon = faTemperatureHigh;
humidityIcom = faDroplet;
windIcon = faWind;

}
