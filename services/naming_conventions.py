# naming_conventions.py
naming_conventions = {
    'CONTROLLER': {
        'TEMPLATE_CONTROLLER': "EndUserController",
        'TEMPLATE_ENTITY_SERVICE_INTERFACE_DECLARATION_CONSTRUCTOR': "endUserService",
        'TEMPLATE_ENTITY_SERVICE_INTERFACE_IMPLEMENTATION': "_endUserService"
    },
    'Contracts': {
        'TEMPLATE_REGISTRATION_REQUEST': "EndUserRegistrationRequest"
    },
    'Application': {
        'TEMPLATE_ENTITY_SERVICE_INTERFACE_DECLARATION': "EndUserService",
        'TEMPLATE_REPOSITORY_INTERFACE_CONSTRUCTOR': "endUserRepo",
        'TEMPLATE_REPOSITORY_INTERFACE_CLASS': "_endUserRepo"
    },
    'Interface': {
        'TEMPLATE_ENTITY_SERVICE_INTERFACE': "IEndUserService",
        'TEMPLATE_ENTITY_REPOSITORY_INTERFACE': "IEndUserRepository"
    },
    'Domain': {
        'TEMPLATE_ENTITY_CLASS': "EndUser"
    },
    'INFRASTRUCTURE': {
        'TEMPLATE_REPOSITORY_INTERFACE_IMPLEMENTATION': "EndUserRepository"
    }
}