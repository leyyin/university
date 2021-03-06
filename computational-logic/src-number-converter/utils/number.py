def convert_to_int(var):
    """
    Tries to convert an number to int.
    :param var
    :returns the value of the int or None if it fails
    """
    try:
        return int(var)
    except ValueError:
        return None


def convert_to_float(var):
    """
    Tries to convert an number to float.
    :param var
    :returns the value of the float or None if it fails
    """
    try:
        return float(var)
    except ValueError:
        return None
