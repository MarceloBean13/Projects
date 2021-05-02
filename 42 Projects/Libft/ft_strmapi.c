/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_strmapi.c                                       :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: mfeijao <marvin@42.fr>                     +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2021/02/24 15:53:12 by mfeijao           #+#    #+#             */
/*   Updated: 2021/02/24 15:54:07 by mfeijao          ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include "libft.h"

char	*ft_strmapi(const char *s, char (*f)(unsigned int, char))
{
	char			*temp;
	unsigned int	i;

	i = 0;
	if (!s)
		return (NULL);
	if (!f)
		return (ft_strdup(s));
	if (!(temp = (char *)malloc(sizeof(char)
					* ft_strlen(s) + 1)))
		return (NULL);
	while (s[i])
	{
		temp[i] = (*f)(i, s[i]);
		i++;
	}
	temp[i] = '\0';
	return (temp);
}
