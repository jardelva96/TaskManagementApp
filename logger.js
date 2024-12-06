// logger.js
const winston = require('winston');

// Criando um logger com diferentes níveis de log (info, warn, error, etc.)
const logger = winston.createLogger({
    level: 'info',
    transports: [
        new winston.transports.Console({ format: winston.format.simple() }),
        new winston.transports.File({ filename: 'logs/app.log' })
    ],
});

module.exports = logger;
