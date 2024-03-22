import http from 'k6/http';
import { sleep } from 'k6';

export let options = {
    vus: 10, // Simulate 10 concurrent users
    duration: '5m', // Run the test for 5 minutes
};

export default function () {
    http.get('https://localhost:5054/Exception/Get');
    sleep(1);
}
