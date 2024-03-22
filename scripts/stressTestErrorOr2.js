import http from 'k6/http';
import { sleep } from 'k6';

export let options = {
    stages: [
        { duration: '2m', target: 1000 }, // ramp up to 100 users over 2 minutes
        { duration: '3m', target: 1000 }, // stay at 100 users for 3 minutes
        { duration: '2m', target: 0 },   // ramp down to 0 users over 2 minutes
    ],
};

export default function () {
    http.get('https://localhost:5054/ErrorOr/Get');
    sleep(1);
}
